using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coli){
		if (coli.tag == "Player") {
			NivelesDes.niveles.GNivel2 ();
			NivelesDes.niveles.nivel_3 = 1;
			PlayerPrefs.SetInt ("Niv3",NivelesDes.niveles.nivel_3);
			Application.LoadLevel ("Ganar2");
		}
		
	}
}
