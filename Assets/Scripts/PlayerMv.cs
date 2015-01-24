using UnityEngine;
using System.Collections;

public class PlayerMv : MonoBehaviour {

	private string[] axis;
	private string brakeBtn;
	private Vector3 axisForce = Vector3.zero;
	private ThrustManager tm;

	public int PlayerNumber = 1;

	private void Start () {
		if (PlayerNumber == 1) {
			axis = new string[] {"P1_xAxis", "P1_yAxis", "P1_zAxis"};
			brakeBtn = "P1_airBrake";
		} else if (PlayerNumber == 2) {
			axis = new string[] {"P2_xAxis", "P2_yAxis", "P2_zAxis"};
			brakeBtn = "P2_airBrake";
		}

		tm = transform.GetComponentInChildren<ThrustManager>();
	}

	private void Update () {
		for(int i = 0; i < 3; i++) {
			axisForce[i] = Input.GetAxis(axis[i]);
		}
	}

	private void FixedUpdate () {
		rigidbody.angularDrag = (Input.GetButton (brakeBtn)) ? 1.0f : 0.05f;
		tm.SendMessage("SetThrust", axisForce);
		rigidbody.AddRelativeForce(axisForce);
		axisForce = Vector3.zero;
	}
}
