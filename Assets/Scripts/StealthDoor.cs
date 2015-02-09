using UnityEngine;
using System.Collections;

public class StealthDoor : MonoBehaviour {

	public GameObject OpenDoor;
	public GameObject ClosedDoor;
	public float CountdownTime = 0f;

	void Awake(){
		OpenDoor.SetActive (false);
		ClosedDoor.SetActive (true);
		}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
				ClosedDoor.SetActive (false);
				OpenDoor.SetActive (true);

		}
	}

	void Update(){
						CountdownTime -= Time.deltaTime;
						if (CountdownTime <= 0) {
								OpenDoor.SetActive (false);
								ClosedDoor.SetActive (true);
						}
	}
}