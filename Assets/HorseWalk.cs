using UnityEngine;
using System.Collections;

public class HorseWalk : MonoBehaviour {

    Animator animator;

   // float walk_Speed;
    bool isWalking;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    public void Move(Vector3 move, bool crouch, bool jump)
    {
        //walk_Speed = move.z;
    }

	// Update is called once per frame
	void Update () {
		Vector3 walk_Speed =  transform.parent.gameObject.GetComponent<Rigidbody>().velocity;
		if (walk_Speed.z < 0.0) {
			animator.SetFloat ("walk_Speed", -1 * (walk_Speed.z), 0.05f, Time.deltaTime);
			GameObject HorseWalkAudio = GameObject.Find ("HorseWalkAudio");
			if (!HorseWalkAudio.GetComponent<AudioSource> ().isPlaying) {
				HorseWalkAudio.GetComponent<AudioSource> ().Play ();
			}
		} else if (walk_Speed.z > 0.0) {
			animator.SetFloat ("walk_Speed", walk_Speed.z, 0.05f, Time.deltaTime);
			GameObject HorseWalkAudio = GameObject.Find ("HorseWalkAudio");
			if (!HorseWalkAudio.GetComponent<AudioSource> ().isPlaying) {
				HorseWalkAudio.GetComponent<AudioSource> ().Play ();
			}
		} else if (walk_Speed.z == 0) {
			GameObject HorseWalkAudio = GameObject.Find ("HorseWalkAudio");
			//if (HorseWalkAudio.GetComponent<AudioSource> ().isPlaying) {
			HorseWalkAudio.GetComponent<AudioSource> ().Stop ();
			//}
		}
	}
}
