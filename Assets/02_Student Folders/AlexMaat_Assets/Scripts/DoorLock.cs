using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour {
	public List<MeshRenderer> meshRenderers;
	public Material lockedMaterial;
	public Material unlockedMaterial;
	[HideInInspector] public bool isLocked = true;

	void Start() {
		this.Sync();
	}

	private void Sync() {
		this.meshRenderers.ForEach(meshRenderer => {
			meshRenderer.materials = new Material[] {
				this.isLocked ? this.lockedMaterial : this.unlockedMaterial
			};
		});
	}

	[ContextMenu("Lock")]
	public void Lock() {
		if (this.isLocked) return;

		this.isLocked = true;
		this.Sync();
	}	

	[ContextMenu("Unlock")]
	public void Unlock() {
		if (!this.isLocked) return;

		this.isLocked = false;
		this.Sync();
	}
}
