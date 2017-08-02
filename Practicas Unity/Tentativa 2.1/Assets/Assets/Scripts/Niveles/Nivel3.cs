using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		if (!NivelesDes.niveles.DarNivel3 ()) {
			gameObject.SetActive(false);
		}
		if (NivelesDes.niveles.DarNivel3 ())
			CandadoN3.instance.quitaCandado ();
	}

	void OnMouseDown(){
		if(NivelesDes.niveles.DarNivel3()){
			Application.LoadLevel ("Nivel3");
		}
	}
}
