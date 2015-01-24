using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	public GameObject projectile;
	private GameObject weapon;
	private float nextFire = 0f;

	private float fireRate;
	private float speed;
	
	public bool armed {
		get { return weapon != null; }
	}

	Animator anim;

	private void Awake() {
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.tag) {
			case "Weapon":
			weapon = coll.gameObject;
			anim.CrossFade("SoldierW" + coll.name, 0f);
			Weapon attrs = coll.GetComponent<Weapon>();
			fireRate = attrs.attackSpeed;
			speed = attrs.projectileSpeed;
			coll.gameObject.renderer.enabled = false;
			break;
		}
	}

	private void Update() {
		if (Input.GetButton("Fire1") && armed && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject bullet = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
			Projectile p = bullet.GetComponent<Projectile>();
			p.speed = transform.localScale.x * speed * -1;
		}
	}
}