using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed;

	private void Update() {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.layer == LayerMask.NameToLayer("Impassible")) {
			Destroy(gameObject);
		}
	}

}
