using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	private Vector3 spin;

	void Start() {
		spin = new Vector3 (15, 30, 45);
	}

	void Update () {
		transform.Rotate(spin * Time.deltaTime);
	}
}
