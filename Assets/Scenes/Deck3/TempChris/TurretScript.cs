using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {
	public GameObject projectile;
	private float nextFire = 0f;
	private float fireRate = 0f;
	private float speed = 10f;
	public bool entry = false;
	// Use this for initialization

	void OnTriggerStay2D (Collider2D fireZone) {
		if (fireZone.tag == "Player"){
			entry = true;
		} else { 
			entry = false;
		}
	}
	// Update is called once per frame
	void Update () {
		if ( Time.time > nextFire && entry) {
			nextFire = Time.time + fireRate;
			Vector3 position = transform.position;
			position.y -= 0.03f;
			GameObject bullet = (GameObject)Instantiate(projectile, position, Quaternion.identity);
			Projectile p = bullet.GetComponent<Projectile>();
			p.speed = transform.localScale.x * speed * -1;
		}
	}
}
