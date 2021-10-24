using UnityEngine;
using System.Linq;
using System.Collections.Generic;

[RequireComponent(typeof(Lockable))]
public class PowerableShieldGenerator : MonoBehaviour {
	[SerializeField] private List<GameObject> hiddenUntilPowered;

	void Start() {
		Lockable lockable = this.GetComponent<Lockable>();

		lockable.onLock.AddListener(() => {
			this.hiddenUntilPowered.ForEach(go => go.SetActive(false));
		});
		lockable.onUnlock.AddListener(() => {
			this.hiddenUntilPowered.ForEach(go => go.SetActive(true));
		});
	}
}
