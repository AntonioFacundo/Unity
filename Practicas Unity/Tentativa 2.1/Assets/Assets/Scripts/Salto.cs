using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour {

	public static Salto instance;

	private Rigidbody2D rb2d;
	private AudioSource audi;
	public float veloy = 8f;
	private Animator anim;

	private bool s;
	private bool s2;

	void Awake(){
		anim = GetComponent<Animator> ();
		audi = GetComponent<AudioSource> ();
		rb2d = GetComponent<Rigidbody2D> ();
		Salto.instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			if (s) {
				rb2d.velocity = new Vector2 (rb2d.velocity.x, veloy);
				s = false;
				audi.Play ();
				anim.SetTrigger ("Salto");

			} else if (s2) {
				rb2d.velocity = new Vector2 (rb2d.velocity.x, veloy - 0.2f);
				s2 = false;
				audi.Play ();
				anim.SetTrigger ("Salto2");
			}

		}

		if(rb2d.velocity.y == 0){
			s = true;
			s2 = true;
		}

	}

	public void Choque(){
	
		s = false;
		s2 = false;
	} 
	public void StarRun(){
	
		s = true;
		s2 = true;

	}

	public void Saltito(){
	
		s2 = true;

	}
}
