using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissile : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    Vector3 mouse;

    // Use this for initialization
    void Start()
    {
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mouse = Camera.main.ScreenToWorldPoint(mousePositionVector3);
        //transform.up = mouse - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
             mouse, speed * Time.deltaTime);


    }
}

