using UnityEngine;
using System.Collections;

public class StealthDoor : MonoBehaviour {

	public GameObject OpenDoor;
	
	void Update(){
			if (Input.GetKey (KeyCode.E)) {
			OpenDoor.SetActive(false);
				}
		}
	}