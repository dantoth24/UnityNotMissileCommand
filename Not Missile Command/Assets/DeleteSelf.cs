using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSelf : MonoBehaviour {

    public float destroyafter = 5f;
    float time;
	// Use this for initialization
	void Start () {
        time = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= destroyafter)
        {
            Destroy(gameObject);
        }
	}
}
