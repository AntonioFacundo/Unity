using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoPrueba : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float moveSpeed = 3;
	public float jumpHeigth = 4;


	//Checar el suelo

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJump;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle (groundCheck.position,groundCheckRadius,whatIsGround);

	}

	// Update is called once per frame
	void Update () {

		if (grounded)
			doubleJump = false;

		if (Input.GetMouseButtonDown (0) && grounded) {
			rb2d.velocity = new Vector2 (rb2d.velocity.x, jumpHeigth);	
		}
		if (Input.GetMouseButtonDown (0) && !doubleJump && !grounded) {
			rb2d.velocity = new Vector2 (rb2d.velocity.x, jumpHeigth);	
			doubleJump = true;

		}
	}
}