using UnityEngine;
using System.Collections;

public class PlayerMv : MonoBehaviour {

	// Controls
	static string xAxis = "xAxis";
	static string yAxis = "yAxis";
	static string zAxis = "zAxis";

	private string[] axis;
	private Vector3 axisForce = Vector3.zero;

	private void Start () {
		axis = new string[] {xAxis, yAxis, zAxis};
	}

	private void Update () {
		for(int i = 0; i < 3; i++) {
			axisForce[i] = Input.GetAxis(axis[i]);
		}
	}

	private void FixedUpdate () {
		rigidbody.AddRelativeForce(axisForce);
		axisForce = Vector3.zero;

		// print var
		Debug.Log(rigidbody.velocity);
	}
}
