using System.Collections;
using UnityEngine;

public class Powerups : MonoBehaviour {
    public bool doublePoints;
    public bool Magnet;
    public bool shouldDouble;

    public float powerupLenght;
    private PowerupsManager thePowerupsManager;
	// Use this for initialization
	void Start () {
        thePowerupsManager = FindObjectOfType<PowerupsManager>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            thePowerupsManager.ActivatePowerup(doublePoints, Magnet, powerupLenght,shouldDouble);
         
        }
        gameObject.SetActive(false);
    }
}
