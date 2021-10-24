using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
	public float height = 5f;
	public float speed = 1f;

	[SerializeField] private List<GameObject> enabledOnTravel;
	[SerializeField] private List<GameObject> disabledOnFinish;
	[SerializeField] private List<GameObject> disabledOnAwake;
	private BoxCollider trigger;
	private AudioSource audioSource;
	private Vector3 originalPosition;

	void Start() {
		this.trigger = this.GetComponent<BoxCollider>();
		this.audioSource = this.GetComponent<AudioSource>();

		this.disabledOnAwake.ForEach(go => go.SetActive(false));
	}

	void OnTriggerEnter(Collider other) {
		this.StartCoroutine(this.MoveElevator(other.gameObject));	
	}

	public IEnumerator MoveElevator(GameObject player) {
		this.audioSource.Play();
		this.enabledOnTravel.ForEach(go => go.SetActive(true));
		this.originalPosition = this.transform.position;
		player.transform.SetParent(this.transform, true);

		this.trigger.enabled = false;

		float height = 0f;
		while (height <= this.height) {
			height += this.speed * Time.deltaTime;
			this.MoveElevatorTo(height);
			yield return new WaitForEndOfFrame();
		}
		height = this.height;
		this.MoveElevatorTo(height);
		this.disabledOnFinish.ForEach(go => go.SetActive(false));
		player.transform.SetParent(null, true);
	}

	private void MoveElevatorTo(float height) {
		this.transform.position = this.originalPosition + height * Vector3.up;
	}
}
