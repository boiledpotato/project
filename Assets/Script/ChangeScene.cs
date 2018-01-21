using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string scene = "Game";

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (scene);
		}
	}

	public void loadScene(string scene) {
		SceneManager.LoadScene (scene);
	}
}
