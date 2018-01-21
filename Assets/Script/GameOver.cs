using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public float threshold;
    // Use this for initialization
    public Text gameoverText;
    public Button BtnNextStage;
    public Button BtnPlayAgain;
    void Start()
    {
        gameoverText.text = "";
    }
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            gameoverText.text = "Game Over";
            BtnPlayAgain.gameObject.SetActive(true);
        }
       
        if (transform.position.y < threshold)
        {
            GetComponent<InputMovement>().enabled = false;
        }

    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("FinishLine")) {
            gameoverText.text = "Stage Cleared!";
        }
        if (other.gameObject.CompareTag("FinishLine"))
        {
            BtnNextStage.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("FinishLine"))
        {
            GetComponent<InputMovement>().enabled = false;
        }
    }

}