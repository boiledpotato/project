using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour {
    public Text gameoverText;
    public Button BtnPlayAgain;
    // Use this for initialization
    void Start()
    {
        gameoverText.text = "";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyObj"))
        {
            gameoverText.text = "Game Over";
            BtnPlayAgain.gameObject.SetActive(true);
            GetComponent<InputMovement>().enabled = false;
        }
       
    }
}
