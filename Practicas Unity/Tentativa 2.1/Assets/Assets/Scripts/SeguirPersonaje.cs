using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour {

	public static SeguirPersonaje instance;

	private AudioSource audi;

	public Rigidbody2D personaje;
	public int separacion = 3;
	public int comenzar = -5;
	// Update is called once per frame

	void Awake(){
		audi = GetComponent<AudioSource> ();
		SeguirPersonaje.instance = this;
	}
	void Update () {
		if(personaje.position.x > comenzar && personaje.position.x + separacion > transform.position.x)
		transform.position = new Vector3 (personaje.position.x + separacion, transform.position.y, transform.position.z);
	}

	public void stopSound(){

		audi.Stop ();
	}
}
