using UnityEngine;
using System.Collections;

public class PlayerMv : MonoBehaviour {

	public int PlayerNumber = 1;

	private string[] axis;
	private Vector3 axisForce = Vector3.zero;

	private void Start () {
		if (PlayerNumber == 1) {
			axis = new string[] {"P1_xAxis", "P1_yAxis", "P1_zAxis"};
		} else if (PlayerNumber == 2) {
			axis = new string[] {"P2_xAxis", "P2_yAxis", "P2_zAxis"};
		}
	}

	private void Update () {
		for(int i = 0; i < 3; i++) {
			axisForce[i] = Input.GetAxis(axis[i]);
		}
	}

	private void FixedUpdate () {
		rigidbody.AddRelativeForce(axisForce);
		axisForce = Vector3.zero;
	}
}
