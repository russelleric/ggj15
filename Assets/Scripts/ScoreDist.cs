using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDist : MonoBehaviour {
	
	public Color ColorP1;
	public Color ColorP2;
	public Transform PlayersMiddlePoint;
	public Text DistText;

	// settings
	private string p1WinSceneName = "winP1";
	private string p2WinSceneName = "winP2";
	private string floatDisplayFormat = "F2";
	// goal x positions
	private float goalP1 = 25;
	private float goalP2 = -25;

	void Update () {
		// game over
		if (PlayersMiddlePoint.position.x >= goalP1 || PlayersMiddlePoint.position.x <= goalP2) {
			// load correct scene, uses position
			Application.LoadLevel((PlayersMiddlePoint.position.x > 0) ? p1WinSceneName : p2WinSceneName);
		} else {
			if (PlayersMiddlePoint.position.x > 0) {
				// player 1 advantage
				DistText.text = (goalP1 - PlayersMiddlePoint.position.x).ToString(floatDisplayFormat);
				DistText.color = ColorP1;
			} else {
				// player 2 advantage
				DistText.text = (-1.0f * (goalP2 - PlayersMiddlePoint.position.x)).ToString(floatDisplayFormat);
				DistText.color = ColorP2;
			}
		}
	}
}
