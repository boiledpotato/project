using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage1 : MonoBehaviour {
    public string scene = "Stage2";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
