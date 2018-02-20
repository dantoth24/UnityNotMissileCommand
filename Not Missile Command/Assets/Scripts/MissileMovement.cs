using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour {
	public float speed = 2f;
	public Transform target;
	public GameObject explosion;

	bool exploded = false;

	// Use this for initialization
	void Start () {
		transform.up = target.position - gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			transform.position = Vector2.MoveTowards (transform.position, 
				target.transform.position, speed * Time.deltaTime);
		} else {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "PlayerMissile") {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (other.gameObject);
			if (!exploded) {
				score.sc += 10;
			}
			exploded = true;
			Destroy (gameObject);
		}
	}
}
