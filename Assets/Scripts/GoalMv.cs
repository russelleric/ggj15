using UnityEngine;
using System.Collections;

public class GoalMv : MonoBehaviour {


	private float distance = 100.0f;
	private float variation = 50.0f;

	private void OnTriggerEnter(Collider other) {
		Debug.Log ("hit");
		float xOffset = Random.Range(-variation, variation);
		float yOffset = Random.Range(-variation, variation);
		transform.Translate(new Vector3(xOffset,
		                                yOffset,
		                                distance),
		                    			Space.World);
	}
}
