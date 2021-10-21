using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Door : MonoBehaviour {
	public GameObject mesh;
	public ParticleSystem particles;
	public List<DoorLock> locks = new List<DoorLock>();
	private bool isOpen = false;

	void Update() {
		if (this.locks.All(l => !l.isLocked)) this.Open();
		else this.Close();
	}

	private void Sync() {
		this.mesh.SetActive(!this.isOpen);
	}

	[ContextMenu("Open")]
	public void Open() {
		if (this.isOpen) return;

		this.isOpen = true;
		this.particles.Play();
		this.Sync();
	}

	[ContextMenu("Close")]
	public void Close() {
		if (!this.isOpen) return;

		this.isOpen = false;
		this.Sync();
	}
}
