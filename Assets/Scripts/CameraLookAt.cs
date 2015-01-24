using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {

	public Transform CameraTarget;

	private void Update () {
		transform.LookAt(CameraTarget.position);
	}
}
