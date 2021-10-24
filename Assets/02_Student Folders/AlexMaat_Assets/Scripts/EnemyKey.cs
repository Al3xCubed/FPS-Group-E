using UnityEngine;

[RequireComponent(typeof(Health))]
public class EnemyKey : MonoBehaviour {
	public DoorLock doorLock;

	private Health health;

	void Start() {
		this.health = this.GetComponent<Health>();
		this.health.onDie += () => this.doorLock.Unlock();
	}
}
