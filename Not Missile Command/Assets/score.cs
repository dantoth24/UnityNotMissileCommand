using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour {
	public static int sc;
	TextMeshProUGUI text;


	// Use this for initialization
	void Awake () {
		sc = 0;
		text = GetComponentInChildren<TextMeshProUGUI> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + sc;
	}
}
