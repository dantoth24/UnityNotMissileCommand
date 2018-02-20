using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int speed = 500;
    public Rigidbody2D missile;
    GameObject player;
    Transform gun;
    Transform crosshair;
    public Transform center;
    // Use this for initialization
    void Start () {
        player = gameObject;
        gun = player.transform.GetChild(1);
        center = player.transform.GetChild(2);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mousePositionVector3 = Camera.main.ScreenToWorldPoint(mousePositionVector3);


        Vector3 targetdir = mousePositionVector3 - gun.position;
        gun.rotation = Quaternion.LookRotation(Vector3.forward, targetdir);

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D bulletInstance = Instantiate(missile, gun.GetChild(0).position, gun.rotation) as Rigidbody2D;
            bulletInstance.GetComponent<Rigidbody2D>().AddForce(targetdir*100);

            Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
