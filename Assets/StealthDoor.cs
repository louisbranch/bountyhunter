using UnityEngine;
using System.Collections;

public class StealthDoor : MonoBehaviour {

	public GameObject OpenDoor;
	public GameObject ClosedDoor;

	void Awake(){
		OpenDoor.SetActive (false);
		ClosedDoor.SetActive (true);
		}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (Input.GetKey (KeyCode.E)) {
				ClosedDoor.SetActive (false);
				OpenDoor.SetActive (true);
		}
	}
}