using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar1: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coli){
		if (coli.tag == "Player") {
			NivelesDes.niveles.GNivel1 ();
			NivelesDes.niveles.nivel_2 = 1;
			PlayerPrefs.SetInt ("Niv2", NivelesDes.niveles.nivel_2);
			Application.LoadLevel ("Ganar1");
		
		}
	}
}
