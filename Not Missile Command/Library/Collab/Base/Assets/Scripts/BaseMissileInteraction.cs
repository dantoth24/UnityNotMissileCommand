using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMissileInteraction : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Missile") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
