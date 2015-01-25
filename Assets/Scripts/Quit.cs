using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	private string quitKey = "Cancel";
	
	void Update () {
		if(Input.GetButton(quitKey)){
			Application.Quit();
		}
	}
}
