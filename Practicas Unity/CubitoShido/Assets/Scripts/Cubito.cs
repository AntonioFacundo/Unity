using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cubito : MonoBehaviour {

    public static Cubito instance;

    //Variables del cubo
    private float velocidadZ;
    private Animator anim;
    private Rigidbody rb;
    private Transform tr;

    //Control del cubo
    private float move;
    private bool salto;



    // Use this for initialization
    void Start () {
        Cubito.instance = this;
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator> ();
        velocidadZ = 5;

        //Controles
        move = 3;
        salto = true;
       
	}
	
	// Update is called once per frame
	void Update () {

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, velocidadZ);

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-move, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(move, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.Space) && salto)
        {
            rb.velocity = new Vector3(rb.velocity.x, move*3, rb.velocity.z);
            salto = false;
        }

        if (rb.velocity.z < 1)
        {
            anim.SetTrigger("Stand");
        }
       if(rb.velocity.z != 0)
        {
            anim.SetTrigger("Run");
        }
      
    }

    public float PosicionZ(){

        return tr.position.z;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            salto = true;
        }
        if(other.tag == "Respawn")
        {
            tr.position = new Vector3(0,0,0);
        }
        if(other.tag == "wall")
        {
            rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
        }
    }
}
