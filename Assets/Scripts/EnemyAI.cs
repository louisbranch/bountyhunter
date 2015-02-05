using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {


	private void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			Debug.Log("ENEMY!");
		}
	}

}
