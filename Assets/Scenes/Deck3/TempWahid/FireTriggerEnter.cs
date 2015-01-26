using UnityEngine;
using System.Collections;

public class FireTriggerEnter : MonoBehaviour {
	// Use this for initialization
	Animator anim;

	void Start () {
		anim=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		Debug.Log ("hit fire");
		if (other.tag=="Fire"){
			anim.SetTrigger("isOnFire");
		} 
}
}
