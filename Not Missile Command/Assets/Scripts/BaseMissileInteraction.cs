using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMissileInteraction : MonoBehaviour {

    BaseHealth health;
    public GameObject explosion;

    private void Start()
    {
        health = GetComponent<BaseHealth>();   
    }

    void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Missile") {
            Instantiate(explosion, transform.position, transform.rotation);
            health.health -= 1;
			Destroy (other.gameObject);
		
		}
	}
}
