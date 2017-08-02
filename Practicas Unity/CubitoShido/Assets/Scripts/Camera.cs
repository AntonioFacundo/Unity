using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    private Rigidbody rb;
    public float veloZ;
    private Transform tr;

	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        tr.position = new Vector3(tr.position.x, tr.position.y, Cubito.instance.PosicionZ() - 15);
       // rb.velocity = new Vector3(rb.velocity.x, rb. position.y, veloZ);
	}
}
