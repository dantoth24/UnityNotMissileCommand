using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject missle;
    GameObject player;
    Transform gun;
    Transform crosshair;
    public Transform center;
    // Use this for initialization
    void Start () {
        player = gameObject;
        gun = player.transform.GetChild(1);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mousePositionVector3 = Camera.main.ScreenToWorldPoint(mousePositionVector3);


        Vector3 targetdir = mousePositionVector3 - gun.position;
        gun.rotation = Quaternion.LookRotation(Vector3.forward, targetdir);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject fired = Instantiate(missle,center);
            fired.transform.rotation = gun.rotation;
        }
    }
}
