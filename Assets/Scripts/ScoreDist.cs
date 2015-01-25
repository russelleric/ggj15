using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDist : MonoBehaviour {

	public Color ColorP1;
	public Color ColorP2;
	public Transform PlayersMiddlePoint;
	public Text DistText;

	private float goalP1 = 25;
	private float goalP2 = -25;

	void Update () {
		// game over
		if (PlayersMiddlePoint.position.x >= goalP1 || PlayersMiddlePoint.position.x <= goalP2) {
			string winLvl = (PlayersMiddlePoint.position.x > 0) ? "winP1" : "winP2";
			Application.LoadLevel(winLvl);
		} else {
			if (PlayersMiddlePoint.position.x > 0) {
				// player 1 advantage
				DistText.text = (goalP1 - PlayersMiddlePoint.position.x).ToString("F2");
				DistText.color = ColorP1;
			} else {
				// player 2 advantage
				DistText.text = (-1.0f * (goalP2 - PlayersMiddlePoint.position.x)).ToString("F2");
				DistText.color = ColorP2;
			}
		}
	}
}
