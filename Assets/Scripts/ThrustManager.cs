using UnityEngine;
using System.Collections;

public class ThrustManager : MonoBehaviour {

	public ParticleSystem[] ps; 
	public float EmmisionRate;

	private void Start () {
		// start with no emmision
		foreach(ParticleSystem p in ps) {
			p.emissionRate = 0.0f;
		}
	}

	// helper for SetThrust function sets emmision 
	// based on EmmisionRate variable
	private void SetAxisThrusters (int thrustIndex, float pos, float neg) {
		ps[2 * thrustIndex].emissionRate = pos * EmmisionRate;
		ps[2 * thrustIndex + 1].emissionRate = neg * EmmisionRate;
	}

	// takes vector3 from player input and translates to 
	// thruster particle effects, called from PlayerMv
	public void SetThrust (Vector3 thrust) {
		for(int i = 0; i < 3; i++) {
			if (thrust[i] == 0) {
				// no thrust
				SetAxisThrusters(i, 0.0f, 0.0f);
			} else if (thrust[i] > 0) {
				// positive input (x+, y+, z+)
				SetAxisThrusters(i, thrust[i], 0.0f);
			} else {
				// negative input (x-, y-, z-)
				SetAxisThrusters(i, 0.0f, -1 * thrust[i]);
			}
		}
		
	}
}
