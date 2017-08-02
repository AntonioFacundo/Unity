using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!NivelesDes.niveles.DarNivel2 ()) {
			gameObject.SetActive(false);
		}
		if (NivelesDes.niveles.DarNivel2 ())
			CandadoN2.instance.quitaCandado ();
	}


	void OnMouseDown(){
		if(NivelesDes.niveles.DarNivel2()){
			Application.LoadLevel ("Nivel2");
		}
	}
}
