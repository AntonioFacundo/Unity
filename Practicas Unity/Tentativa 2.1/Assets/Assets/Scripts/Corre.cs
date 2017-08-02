using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corre : MonoBehaviour {

	public static Corre instance;

	private Rigidbody2D rb2d;
	private Collider2D colid;
	private Animator anim;
	public float velo = 5f;
	private bool iniciar = true;
	public float dv = 0f;
	public float dp = 0f;
	private bool choque = true;


	private bool retroceso = true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		colid = GetComponent<Collider2D> ();
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (velo, rb2d.velocity.y);
		Corre.instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (rb2d.velocity.y == 0 && iniciar) {
			rb2d.velocity = new Vector2 (velo, rb2d.velocity.y);
			iniciar = false;
			anim.SetTrigger ("StartRun");
		}

		if (rb2d.velocity.x == 0 && Input.GetMouseButtonDown(0) &&!retroceso) {
			
			rb2d.velocity = new Vector2 (velo, rb2d.velocity.y);
			retroceso = true;
			anim.SetTrigger ("StartRun");
			Salto.instance.StarRun ();
			choque = true;

			//anim.SetTrigger ("Choque2");

		}

		if (rb2d.velocity.x < -3  && !choque) {
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
			retroceso = false;


		}


			

		if (rb2d.velocity.x != velo && rb2d.velocity.x >= -3 && retroceso ) {
		
			rb2d.AddForce (new Vector2(-3f, 0));
			if (choque) {
				anim.SetTrigger ("Choque");
			}
			Salto.instance.Choque ();
			choque = false;


		}

		dv = rb2d.velocity.x;
		dp = rb2d.position.x;

	}

	public void Obstaculo (){


	}

	public void Saltito(){
	
		rb2d.velocity = new Vector2 (rb2d.velocity.x, 5);

	}

	void OnTriggerEnter2D(Collider2D coli){
	
		if(coli.tag == "Conejo"){
			rb2d.velocity = new Vector2 (-1,rb2d.velocity.y);
			Conejo.instance.Voltear ();
			anim.SetTrigger ("StartRun");
			Invoke ("saltoConejo", 1f);
		}

	}

	void saltoConejo(){

		retroceso = true;
		choque = true;
		rb2d.velocity = new Vector2 (velo, rb2d.velocity.y);
	

	}

	public void ChoqueCone(){
	
		rb2d.velocity = new Vector2 (-1, rb2d.velocity.y);

	}

	public void Deactivate(){
		colid.enabled = false;
	}
}
