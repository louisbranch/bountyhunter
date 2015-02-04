using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {
	public GameObject projectile;
	private float nextFire = 0f;
	private float fireRate;
	private float speed=10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Vector3 position = transform.position;
			position.y -= 0.03f;
			GameObject bullet = (GameObject)Instantiate(projectile, position, Quaternion.identity);
			Projectile p = bullet.GetComponent<Projectile>();
			p.speed = transform.localScale.x * speed * -1;
		}
	}
}
