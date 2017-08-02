using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager intance;

    public Vector3 playerStartPoint;
    private Vector3 plataformStartPoint;

	// Use this for initialization
	void Start () {
        GameManager.intance = this;
        GameObject P = GameObject.FindGameObjectWithTag("Player");
        playerStartPoint = P.transform.position;
	}
	
	// Update is called once per frame
	void Update () {		
	}

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }
    public IEnumerator RestartGameCo()
    {
        GameObject P = GameObject.FindGameObjectWithTag("Player");
        P.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        P.transform.position = playerStartPoint;
        P.gameObject.SetActive(true);
    }
}
