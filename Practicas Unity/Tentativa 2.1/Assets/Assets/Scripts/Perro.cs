using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perro : MonoBehaviour {

	private AudioSource audi;

	void Awake(){
	
		audi = GetComponent<AudioSource> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coli){
		
		if (coli.tag == "Player") {
			audi.Play ();	
			CorrePerro.corre.TocaAlan ();
			CorrePerro.corre.tocar = true;
			Invoke ("Morir", audi.clip.length);
		}
		if (coli.tag == "SaltoP")
			CorrePerro.corre.Salta ();

	}

	void Morir(){
	
		Application.LoadLevel ("MainGame");
	}

}

