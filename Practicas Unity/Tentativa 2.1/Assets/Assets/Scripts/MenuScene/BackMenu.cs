using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenu : MonoBehaviour {



	private Rigidbody2D rb2d;


	void Awake(){
	
		rb2d = GetComponent<Rigidbody2D> ();

	}

	void Start () {
		
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rb2d.velocity = new Vector2 (0, 3);
		}
	}
}
