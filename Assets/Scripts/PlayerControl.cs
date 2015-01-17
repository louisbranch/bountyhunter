using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed = 1.0f;

	private bool facingRight = false;
	
	private void Update () {
		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");

		if (hMove != 0) {
			transform.Translate(Vector2.right * hMove * speed * Time.deltaTime);
			if (hMove > 0 && !facingRight) {
				Flip();
			} else if (hMove < 0 && facingRight) {
				Flip();
			}
		}

		if (vMove != 0) {
			transform.Translate(Vector2.up * vMove * speed * Time.deltaTime);
		}
	}

	private void Flip() {
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		facingRight = !facingRight;
	}
}
