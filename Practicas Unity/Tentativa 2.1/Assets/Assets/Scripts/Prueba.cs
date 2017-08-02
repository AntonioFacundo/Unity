using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {
	
	private Rigidbody2D rb2d;
	public float bajar = -3f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Corre.instance.dv > 0) {
			rb2d.velocity = new Vector2 (bajar, 0);
		}
		else {
			rb2d.velocity = Vector2.zero;
		}

		if (transform.position.x < Corre.instance.dp -17.46976f) {
			transform.Translate (Vector2.right * 40.1152f);
		}
			
	}
}
