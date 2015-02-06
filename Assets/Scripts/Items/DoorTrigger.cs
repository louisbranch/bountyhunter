using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	Animator anim;
	
	void Start () {
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D other) {
			
		if (other.tag == "Player") {
			anim.SetTrigger ("OpenDoor");
			//collider.enabled = false;
			} 
			
		// Alternative to Opening Door
		if (Input.GetKey (KeyCode.E)) {
			anim.SetTrigger ("OpenDoor");
				}
	}
}