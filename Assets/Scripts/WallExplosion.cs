using UnityEngine;
using System.Collections;

public class WallExplosion : MonoBehaviour {

	public float totalTime = 10f;

	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		if (totalTime <= 0) {
			Destroy(gameObject);
				}
	}
}
