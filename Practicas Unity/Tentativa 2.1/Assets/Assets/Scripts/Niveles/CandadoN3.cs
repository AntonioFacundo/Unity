using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoN3 : MonoBehaviour {

	public static CandadoN3 instance;
	// Use this for initialization
	void Start () {
		CandadoN3.instance = this;
	}

	// Update is called once per frame
	void Update () {

	}

	public void quitaCandado(){

		gameObject.SetActive (false);

	}
}