using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrePrueba : MonoBehaviour {

	private Rigidbody2D rb2d;


	public float velox = 3;

	void Awake(){
	
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Start(){

		rb2d.velocity = new Vector2 (velox, rb2d.velocity.y);

	}

	void Update(){
	


	}
}
