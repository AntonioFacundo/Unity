using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conejo : MonoBehaviour {

	public static Conejo instance;

	private Rigidbody2D rb2d;
	private SpriteRenderer spri;
	private Collider2D cone;

	private bool muerto = false;

	private int vel = 3;
	// Use this for initialization
	void Start () {

		Conejo.instance = this;

		rb2d = GetComponent<Rigidbody2D> ();
		spri = GetComponent<SpriteRenderer> ();
		cone = GetComponent<Collider2D> ();

		vel = -vel;
	}
	
	// Update is called once per frame
	void Update () {
		if (!muerto) {
			rb2d.velocity = new Vector2 (vel, 0);
		}
	}

	public void Voltear(){

		vel = -vel;

		if (spri.flipX == false)
			spri.flipX = true;
		else
			spri.flipX = false;
	}

	void OnTriggerEnter2D(Collider2D coli){

		if (coli.tag == "Player") {
		
			rb2d.velocity = new Vector2 (0, -4);
			muerto = true;
			spri.flipY = true;

			cone.enabled = false;
			Corre.instance.Saltito ();
			Salto.instance.Saltito ();
		
		} 



	}

}


