using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour {

	private Rigidbody2D rb2d;

	void Awake(){
	
		rb2d = GetComponent<Rigidbody2D> ();

	}
	// Use this for initialization
	void Start () {
		rb2d.velocity = new Vector2 (-4, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
