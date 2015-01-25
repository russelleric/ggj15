using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text uiTimeDisplay;

	private float playerTime = 30.0f;
	private string gameoverLvl = "gameOver";

	public void Update () {
		playerTime -= Time.deltaTime;
		uiTimeDisplay.text = playerTime.ToString("F1");

		if (playerTime <= 0.0f) {
			// game over
			Application.LoadLevel(gameoverLvl);
		}
	}

	// called from GoalMv
	public void AddTime (float amount) {
		playerTime += amount;
	}
}
