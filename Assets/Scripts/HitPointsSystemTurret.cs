using UnityEngine;
using System.Collections;

public class HitPointsSystemTurret : MonoBehaviour {
	Animator anim;
	public GameObject other;
	public float health;
	void Start () {
		anim = GetComponent<Animator>();
	}
	private void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.gameObject.tag) {
		case "Projectile":
			health--;
			if (health <= 0) {
				//Destroy(gameObject);
				anim.SetBool("destroyed", true);
				other.GetComponent<TurretScript>().enabled = false;
			}
			break;
		}
	}

}
