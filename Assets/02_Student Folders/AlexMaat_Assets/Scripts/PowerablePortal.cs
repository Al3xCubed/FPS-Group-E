using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(Lockable), typeof(MeshCollider))]
public class PowerablePortal : MonoBehaviour {
	[SerializeField] private Material poweredMaterial;
	[SerializeField] private Material unpoweredMaterial;
	[SerializeField] private Objective objective;

	void Start() {
		AudioSource audioSource = this.GetComponent<AudioSource>();
		Lockable lockable = this.GetComponent<Lockable>();
		MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
		MeshCollider meshCollider = this.GetComponent<MeshCollider>();

		meshCollider.enabled = false;

		lockable.onLock.AddListener(() => {
			audioSource.Play();
			meshRenderer.materials = new Material[]{
				this.unpoweredMaterial
			};
		});
		lockable.onUnlock.AddListener(() => {
			audioSource.Play();
			meshRenderer.materials = new Material[]{
				this.poweredMaterial
			};
			this.objective.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + this.objective.title);
			meshCollider.enabled = true;
		});
	}
}
