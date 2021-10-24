using System.Collections.Generic;
using UnityEngine;

public class PlayTest : MonoBehaviour {
	public List<Health> easilyKillable = new List<Health>();

	void Start() {
		foreach (Health health in this.easilyKillable) {
			health.maxHealth = 1f;
		}
	}
}
