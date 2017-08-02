using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		if (Input.GetMouseButtonDown (0))
			Application.LoadLevel ("Niveles");
	}
}
