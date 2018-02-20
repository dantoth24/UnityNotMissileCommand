using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	void Start() {
		Destroy (gameObject, 
			this.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).length + 1f);
	}
}
