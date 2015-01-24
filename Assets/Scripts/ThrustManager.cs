using UnityEngine;
using System.Collections;

public class ThrustManager : MonoBehaviour {

	public ParticleSystem[] ps; 
	public float EmmisionRate;

	private void Start () {
		foreach(ParticleSystem p in ps) {
			p.emissionRate = 0.0f;
		}
	}

	private void SetAxisThrusters (int thrustIndex, float pos, float neg) {
		ps[2 * thrustIndex].emissionRate = pos * EmmisionRate;
		ps[2 * thrustIndex + 1].emissionRate = neg * EmmisionRate;
	}

	public void SetThrust (Vector3 thrust) {
		for(int i = 0; i < 3; i++) {
			if (thrust[i] == 0) {
				SetAxisThrusters(i, 0.0f, 0.0f);
			} else if (thrust[i] > 0) {
				SetAxisThrusters(i, thrust[i], 0.0f);
			} else {
				SetAxisThrusters(i, 0.0f, -1 * thrust[i]);
			}
		}
		
	}
}
