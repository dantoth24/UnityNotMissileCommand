using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissile : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    Vector3 mouse;
    Rigidbody2D move;

    // Use this for initialization
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
        
        Vector3 mousePositionVector3 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mouse = Camera.main.ScreenToWorldPoint(mousePositionVector3);
        move.velocity = mouse;
        //mouse.
        //transform.up = mouse - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //move.AddForce(transform.up * speed);
       // transform.position = Vector2.MoveTowards(transform.position,
         //    mouse, speed * Time.deltaTime);


    }
}

