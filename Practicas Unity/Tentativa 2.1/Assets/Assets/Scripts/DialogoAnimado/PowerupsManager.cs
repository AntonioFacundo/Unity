using System.Collections;
using UnityEngine;

public class PowerupsManager : MonoBehaviour {
    private bool doublePoints;
    private bool Magnet = false;
    private bool shouldDouble;
    private bool powerupActive;
    private bool coinMag;
    public float Timer = 0.0f;
    

    private  float powerupLengthCounter;

    private ScoreManager theScoreManager;

    private float normalPointsPerSecond; 
    

	// Use this for initialization
	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (powerupActive)
        {
            powerupLengthCounter -= Time.deltaTime;
        }
        if (shouldDouble)
        {
            theScoreManager.pointsPerSecond = normalPointsPerSecond * 2;
            theScoreManager.shouldDouble = true;
        }
        if (Magnet)
        {
            Timer += 1 * Time.deltaTime;
            if(Timer >=10 )
            {
                Magnet = false;
                Timer = 0;
            }

            GameObject P = GameObject.FindGameObjectWithTag("Player");
            GameObject[] CurrentCoins = GameObject.FindGameObjectsWithTag("Coin");
            GameObject M = GameObject.FindGameObjectWithTag("Magnet");
            foreach (GameObject Coin in CurrentCoins)
            {

                if (Vector3.Distance(Coin.transform.position, P.transform.position) < 0.5)
                {
                    Destroy(Coin.gameObject);
                 
                }


                {
                    if (Magnet == true)
                    {

                        if (Vector3.Distance(Coin.transform.position, P.transform.position) < 5)

                        {
                            Coin.transform.Translate((P.transform.position - Coin.transform.position).normalized * 8 * Time.deltaTime, Space.World);
                        }
                    }
                }
                if (M != null)
                {
                    if (Vector3.Distance(M.transform.position, P.transform.position) < 0.5)
                    {
                        Destroy(GameObject.FindGameObjectWithTag("Magnet"));
                        if (Magnet == false)
                        {
                            Magnet = true;
                        }


                    }
                }




                if (powerupLengthCounter <= 0)
                {
                    theScoreManager.pointsPerSecond = normalPointsPerSecond;
                    theScoreManager.shouldDouble = false;
                    theScoreManager.Magnet = false;
                }
                powerupActive = true;


            }
        }
    }
	
    public void ActivatePowerup(bool points, bool magnet, float time,bool Double)
    {
        doublePoints = points;
        Magnet = magnet;
        powerupLengthCounter = time;
        shouldDouble = Double;

        normalPointsPerSecond = theScoreManager.pointsPerSecond;

        powerupActive = false;
    }
}
