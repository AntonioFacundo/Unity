using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupPoints : MonoBehaviour {

	private Animator anim;
	private AudioSource audi;
    public int scoreToGive;

    private ScoreManager theScoreManager;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audi = GetComponent<AudioSource> ();
        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
		if(other.tag == "Player")
        {
			audi.Play ();
            theScoreManager.AddScore(scoreToGive);
			anim.SetTrigger ("TomarMoneda");
			Invoke ("eliminarMoneda", audi.clip.length);
        }
    }

	void eliminarMoneda(){
		gameObject.SetActive(false);
		//Destroy (gameObject);
	}
}
