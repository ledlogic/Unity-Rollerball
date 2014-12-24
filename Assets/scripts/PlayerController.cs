﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private int count;
	public GUIText countText;
	public GUIText winText;

	void Start() {
		count = 0;
		winText.gameObject.SetActive (false);
		updateCountText();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive(false);
			count++;
			updateCountText();

			if (count >= 16) {
				winText.gameObject.SetActive(true);
			}
		}
	}

	void updateCountText() {
		countText.text = "Count: " + count.ToString ();
	}
}
