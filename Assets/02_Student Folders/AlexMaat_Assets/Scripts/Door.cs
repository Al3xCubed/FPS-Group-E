using UnityEngine;

[RequireComponent(typeof(Animator), typeof(AudioSource), typeof(Lockable))]
public class Door : MonoBehaviour {
	void Start() {
		AudioSource audioSource = this.GetComponent<AudioSource>();
		Animator animator = this.GetComponent<Animator>();
		Lockable lockable = this.GetComponent<Lockable>();
		Objective objective = this.GetComponent<Objective>();

		lockable.onLock.AddListener(() => {
			audioSource.Play();
			animator.SetBool("character_nearby", false);
		});
		lockable.onUnlock.AddListener(() => {
			audioSource.Play();
			animator.SetBool("character_nearby", true);
			objective?.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + objective.title);
		});
	}
}
