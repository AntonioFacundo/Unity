using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrePerro : MonoBehaviour {

	public static CorrePerro corre;

	private Rigidbody2D rb2d;
	public bool tocar = false;
	public float velo = 5;
	public float veloy = 5;

	void Awake(){
	
		rb2d = GetComponent<Rigidbody2D> ();
		CorrePerro.corre = this;

	}

	// Use this for initialization
	void Start () {
		rb2d.velocity = new Vector2(velo,0);

	}
	
	// Update is called once per frame
	void Update () {
		if (rb2d.velocity.x != velo && !tocar)
			rb2d.velocity = new Vector2 (velo, 3);
	}

	public void TocaAlan (){
		rb2d.velocity = new Vector2 (0,0);
	}
	public void Salta(){

		rb2d.velocity = new Vector2 (rb2d.velocity.x, veloy);
	}
}
