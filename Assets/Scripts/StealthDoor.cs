using UnityEngine;
using System.Collections;

public class StealthDoor : MonoBehaviour {

	public bool NearDoor = false;

	void Update() {
		if (NearDoor == true) {
			if (Input.GetKey(KeyCode.E)) {
				Destroy(this.gameObject);
			
			}
		}
	}

	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Player") {
			NearDoor = true;
		}
	}

	void OnTriggerExit2D (Collider2D target) {
		if (target.tag == "Player") {
			NearDoor = false;
		}
	}
}