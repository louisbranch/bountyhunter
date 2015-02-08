using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	/// <summary>
	/// Count Down Script to destroy objects
	/// </summary>

	public float totalTime = 0f;
	
	void Update () {
		totalTime -= Time.deltaTime;
		if (totalTime <= 0) {
			Destroy(gameObject);
				}
	}
}
