using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearCollide : MonoBehaviour {
    private Renderer rnd;
    public Color normalColor;
    public Color triggerColor;

    // Use this for initialization
    void Start () {
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
        }
    }
}
