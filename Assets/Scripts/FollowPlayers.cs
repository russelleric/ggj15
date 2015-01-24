using UnityEngine;
using System.Collections;

public class FollowPlayers : MonoBehaviour {

	private Transform[] players = new Transform[2];

	private void Start () {
		// get transforms of the two player objects
		GameObject[] playerGameObjects = GameObject.FindGameObjectsWithTag("Player");
		for (var i = 0; i < 2; i++) {
			players[i] = playerGameObjects[i].transform;
		}
	}

	private void Update () {
		// move this to middle point between the player objects
		transform.position = players[0].position + 0.5f * (players[1].position - players[0].position);
	}
}
