using UnityEngine;
using System.Collections;

public class FollowPlayers : MonoBehaviour {

	private Transform[] players = new Transform[2];

	private void Start () {
		GameObject[] playerGameObjects = GameObject.FindGameObjectsWithTag("Player");
		for (var i = 0; i < 2; i++) {
			players[i] = playerGameObjects[i].transform;
		}
	}

	private void Update () {
		transform.position = players[0].position + 0.5f * (players[1].position - players[0].position);
	}
}
