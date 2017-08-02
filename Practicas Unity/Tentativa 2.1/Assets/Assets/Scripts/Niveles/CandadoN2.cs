using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoN2 : MonoBehaviour {

	public static CandadoN2 instance;
	// Use this for initialization
	void Start () {
		CandadoN2.instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void quitaCandado(){
	
		gameObject.SetActive (false);

	}
}
