using UnityEngine;
using System.Collections;

public class RotateFx : MonoBehaviour {

	public float speed = 90;

	void Update () {
		// todo add cooler effect
		transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}
}
