using UnityEngine;
using System.Collections;

public class RestartTimer : MonoBehaviour {

	public float TimeUntilRestart = 3.0f;
	public string LevelName;

	private float LoadedTime;

	private void Start () {
		LoadedTime = Time.time;
	}

	private void Update () {
		if (Time.time > LoadedTime + TimeUntilRestart) {
			Application.LoadLevel(LevelName);
		}
	}
}
