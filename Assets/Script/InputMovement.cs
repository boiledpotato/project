using UnityEngine;
using System.Collections;

public class InputMovement : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 normalizedVelocity;
	private bool isStep, isWaitAudio;
	public float maxSpeed;
	public float movePower = 10;
	public float jumpPower = 100;
	public float stepTime = 0.2f;
	public AudioSource audio;
	public AudioClip clip;
	public bool isInputActive = true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		isStep = false;
		isWaitAudio = false;
	}
	
	// Update is called once per frame
	void Update () {
		isStep = false;

		if (isInputActive) {
			// Move forward and backward
			if (Input.GetKey (KeyCode.W)) {
				isStep = true;
				rb.AddForce (transform.forward * movePower);
			} else if (Input.GetKey (KeyCode.S)) {
				isStep = true;
				rb.AddForce (-transform.forward * movePower);
			}
			// Move left and right
			if (Input.GetKey (KeyCode.A)) {
				isStep = true;
				rb.AddForce (-transform.right * movePower);
			} else if (Input.GetKey (KeyCode.D)) {
				isStep = true;
				rb.AddForce (transform.right * movePower);
			}
			// Jump
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.AddForce (transform.up * jumpPower);
			}

			// Limit horizontal speed
			if (rb.velocity.magnitude > maxSpeed) {
				normalizedVelocity = rb.velocity.normalized * maxSpeed;
				normalizedVelocity.y = rb.velocity.y;
				rb.velocity = normalizedVelocity;
			}

			if (isStep && !isWaitAudio) {
				isWaitAudio = true;
				audio.PlayOneShot (clip);
				StartCoroutine (resetWaitAudio ());
			}
		}
	}

	public void setMaxSpeed(float speed) {
		maxSpeed = speed;
	}

	public void toggleInput() {
		isInputActive = !isInputActive;
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Node") {
			maxSpeed += 2;
		}
	}
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Node") {
			maxSpeed -= 2;
		}
	}

	IEnumerator resetWaitAudio() {
		yield return new WaitForSeconds (stepTime);
		isWaitAudio = false;
	}
}
