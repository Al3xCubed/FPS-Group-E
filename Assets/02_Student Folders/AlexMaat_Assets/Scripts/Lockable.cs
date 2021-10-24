using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Lockable : MonoBehaviour {
	public List<DoorLock> locks = new List<DoorLock>();
	private bool isLocked = true;
	public UnityEvent onLock;
	public UnityEvent onUnlock;

	void Update() {
		if (this.locks.All(l => !l.isLocked)) this.Unlock();
		else this.Lock();
	}

	[ContextMenu("Unlock")]
	public void Unlock() {
		if (!this.isLocked) return;

		this.onUnlock.Invoke();
		this.isLocked = false;
	}

	[ContextMenu("Lock")]
	public void Lock() {
		if (this.isLocked) return;

		this.onLock.Invoke();
		this.isLocked = true;
	}
}
