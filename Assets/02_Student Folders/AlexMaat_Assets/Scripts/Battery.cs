using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(Lockable))]
public class Battery : MonoBehaviour {
	[SerializeField] private Material poweredMaterial;
	[SerializeField] private Material unpoweredMaterial;

	void Start() {
		AudioSource audioSource = this.GetComponent<AudioSource>();
		Lockable lockable = this.GetComponent<Lockable>();
		MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();

		lockable.onLock.AddListener(() => {
			audioSource.Play();
			meshRenderer.materials = new Material[]{
				meshRenderer.materials[0],
				this.unpoweredMaterial
			};
		});
		lockable.onUnlock.AddListener(() => {
			audioSource.Play();
			meshRenderer.materials = new Material[]{
				meshRenderer.materials[0],
				this.poweredMaterial
			};
		});
	}
}
