using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
	public float height = 5f;
	public float speed = 1f;

	private BoxCollider trigger;
	private AudioSource audioSource;
	private Transform player;
	private Vector3 originalPlayerPosition;
	private Vector3 originalPosition;

	void Start() {
		this.trigger = this.GetComponent<BoxCollider>();
		this.audioSource = this.GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		this.StartCoroutine(this.MoveElevator(other.gameObject));	
	}

	public IEnumerator MoveElevator(GameObject player) {
		this.audioSource.Play();
		this.player = player.transform;
		this.originalPlayerPosition = this.player.position;
		this.originalPosition = this.transform.position;

		this.trigger.enabled = false;

		float height = 0f;
		while (height <= this.height) {
			height += this.speed * Time.deltaTime;
			this.MoveElevatorTo(height);
			yield return new WaitForEndOfFrame();
		}
		height = this.height;
		this.MoveElevatorTo(height);
	}

	private void MoveElevatorTo(float height) {
		this.transform.position = this.originalPosition + height * Vector3.up;
		this.player.position = this.originalPlayerPosition + height * Vector3.up;
	}
}
