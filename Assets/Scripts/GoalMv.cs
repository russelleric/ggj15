﻿using UnityEngine;
using System.Collections;

public class GoalMv : MonoBehaviour {
	
	private float distance = 100.0f;
	private float variation = 50.0f;
	private float timeReward = 20.0f;
	private Timer sceneTimer;
	private AudioSource aSource;

	private void Start() {
		sceneTimer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
		aSource = gameObject.GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider other) {
		aSource.Play();
		sceneTimer.SendMessage("AddTime", timeReward);
		float xOffset = Random.Range(-variation, variation);
		float yOffset = Random.Range(-variation, variation);
		transform.Translate(new Vector3(xOffset,
		                                yOffset,
		                                distance),
		                    			Space.World);
	}
}
