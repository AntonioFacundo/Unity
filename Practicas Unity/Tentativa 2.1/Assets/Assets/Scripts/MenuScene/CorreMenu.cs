using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorreMenu : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetTrigger ("StartRun");
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (3,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 12)
			transform.position = new Vector2(-12, transform.position.y);
	}
}
