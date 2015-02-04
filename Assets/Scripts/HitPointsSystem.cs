using UnityEngine;
using System.Collections;

public class HitPointsSystem : MonoBehaviour {

	public float health;

	private void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.gameObject.tag) {
		case "Projectile":
			health--;
			if (health <= 0) {
				Destroy(gameObject);
			}
			break;
		}
	}

}
