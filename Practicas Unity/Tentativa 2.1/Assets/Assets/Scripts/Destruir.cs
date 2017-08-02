using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {


	void Awake(){

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coli){
	
		if (coli.tag == "Player") {
			Corre.instance.Deactivate();
			SeguirPersonaje.instance.stopSound ();
			Application.LoadLevel ("Lose");
		} else {
			Destroy (coli.gameObject);
		}

	}
}
