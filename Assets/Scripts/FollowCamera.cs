﻿using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	
	[HideInInspector]public float dampTime = 1f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;

	private void Update () 
	{
		if (target)
		{
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			if (dampTime > 1)
			{
				dampTime -= 0.1f;
			}
		}
	}
}
