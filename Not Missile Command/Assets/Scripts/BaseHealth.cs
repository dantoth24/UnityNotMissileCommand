using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour {

    public int health = 5;
    int lasthealth;
    SpriteRenderer basesprite;
	// Use this for initialization
	void Start () {
        lasthealth = health;
        basesprite = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
        int damage = lasthealth - health;
		while(damage > 0)
        {
            basesprite.color = new Color(basesprite.
                color.r, basesprite.color.g-.2f, basesprite.color.b-.2f);
            damage -= 1;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        lasthealth = health;
	}
}
