using UnityEngine;
using System.Collections;

public class StealthLevel : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Player") {
			Application.LoadLevel ("StealthScene");
		}
	}
}
