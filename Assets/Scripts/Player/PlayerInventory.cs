using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	private GameObject weapon;

	Animator anim;

	private void Awake() {
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.tag) {
			case "Weapon":
			weapon = coll.gameObject;
			anim.CrossFade("SoldierW" + coll.name, 0f);
			Destroy(coll.gameObject);
			break;
		}
	}
}