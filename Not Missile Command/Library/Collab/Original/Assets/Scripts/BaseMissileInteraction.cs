using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMissileInteraction : MonoBehaviour {

    BaseHealth health;

    private void Start()
    {
        health = GetComponent<BaseHealth>();   
    }

    void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Missile") {
            health.health -= 1;
			Destroy (other.gameObject);
		
		}
	}
}
