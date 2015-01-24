using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {

	public Transform CameraTarget;
	private float maxDistance = 15.0f;
	private float currentDistance = 0.0f;

	private void Update () {
		transform.LookAt(CameraTarget.position);

		currentDistance = Vector3.Distance(transform.position,CameraTarget.position);
		// check if too far away from players
		if(currentDistance > maxDistance) {
			// speed based on distance
			transform.Translate(Vector3.forward * (currentDistance - maxDistance) * Time.deltaTime);
		}
	}
}
