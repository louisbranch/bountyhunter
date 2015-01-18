using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed = 1.0f;
	public LayerMask impassibleLayer;
	public float checkerRadius = 0.05f;

	private bool facingRight = false;

	private bool moveN = true;
	private bool moveE = true;
	private bool moveS = true;
	private bool moveW = true;

	Transform north;
	Transform east;
	Transform south;
	Transform west;

	private void Awake() {
		north = transform.Find("North");
		east = transform.Find("East");
		south = transform.Find("South");
		west = transform.Find("West");
	}
	
	private void Update () {
		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");

		moveN = !Physics2D.OverlapCircle(north.position, checkerRadius, impassibleLayer);
		moveE = !Physics2D.OverlapCircle(east.position, checkerRadius, impassibleLayer);
		moveS = !Physics2D.OverlapCircle(south.position, checkerRadius, impassibleLayer);
		moveW = !Physics2D.OverlapCircle(west.position, checkerRadius, impassibleLayer);


		if (hMove > 0) {
			Debug.Log (moveE);
			if (moveE) {
				transform.Translate(Vector2.right * speed * Time.deltaTime);
			}

			if (!facingRight) { 
				Flip();
			}
		} else if (hMove < 0) {
			if (moveW) {
				transform.Translate(-Vector2.right * speed * Time.deltaTime);
			}
			if (facingRight) {
				Flip();
			}
		}

		if (vMove > 0 && moveN) {
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		} else if (vMove < 0 && moveS) {
			transform.Translate(-Vector2.up * speed * Time.deltaTime);
		}
	}

	private void Flip() {
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		facingRight = !facingRight;
	}
}
