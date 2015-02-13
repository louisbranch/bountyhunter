using UnityEngine;
using System.Collections;

public class BossLevel : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Player") {
			Application.LoadLevel ("BossScene");
		}
	}
}
