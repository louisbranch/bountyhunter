using UnityEngine;
using System.Collections;

public class WallExplosion : MonoBehaviour {

	public float totalTime = 60f;
	private float goalTime = 0f;
	
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		if (totalTime <= goalTime) {
			Destroy(gameObject);
				}
	}
}
