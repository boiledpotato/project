using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayController : MonoBehaviour {
	public bool isActive = false;

	void Start() {
		this.gameObject.SetActive (isActive);
	}

	public void toggleActive() {
		isActive = !isActive;
		this.gameObject.SetActive (isActive);
	}
}
