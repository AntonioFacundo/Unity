using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelesDes : MonoBehaviour {

	public static NivelesDes niveles;

	private bool nivel2 = false;
	private bool nivel3 = false;

	public int nivel_2 = 0;
	public int nivel_3 = 0;

	void Awake(){
		if (niveles == null) {
			niveles = this;
			DontDestroyOnLoad (gameObject);
		} else if (niveles != this) {
			Destroy (gameObject);
		}
	}

	void Start(){

		nivel2 = false;
		nivel3 = false;
		nivel_2 = 0;
		nivel_3 = 0;

		if (PlayerPrefs.HasKey ("Niv_2")) {

			nivel_2 = PlayerPrefs.GetInt ("Niv_2");
		}



		if (nivel_2 == 1) {
			nivel2 = true;
		}

		if (PlayerPrefs.HasKey ("Niv_3")) {

			nivel_2 = PlayerPrefs.GetInt ("Niv_3");
		}



		if (nivel_3 == 1) {
			nivel2 = true;
		}
	}

	public void GNivel1(){

			nivel2 = true;
	}

	public bool DarNivel2(){
		return nivel2;

	}

	public void GNivel2(){
	
		nivel3 = true;
	}

	public bool DarNivel3(){
		return nivel3;
	}
}
