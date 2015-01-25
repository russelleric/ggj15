using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	public void ChangeLvl (string levelName) {
		Application.LoadLevel(levelName);
	}

	public void Quit () {
		Application.Quit();
	}
}
