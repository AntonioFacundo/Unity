﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GANAR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coli){
		if(coli.tag == "Player")
			Application.LoadLevel ("MainGame");
	}
}
