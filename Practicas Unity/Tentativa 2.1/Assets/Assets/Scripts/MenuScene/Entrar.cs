using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrar : MonoBehaviour {

	private AudioSource audi;
	private bool entrar = true;

	// Use this for initialization
	void Start () {
		audi = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && entrar) {
			audi.Play ();
			Invoke ("entrarLevels", 3);
			entrar = false;
		}
	}

	void entrarLevels(){
		
		Application.LoadLevel ("Niveles");
	}
}
