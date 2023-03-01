using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //public bool isGrounded;
    public GameObject character;
    private Rigidbody rb;
    private Movemont movementScript;
    public float jump = 7.0f; 
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {   
        //isGrounded = true;
        sound = GetComponent<AudioSource>();
        rb = character.GetComponent<Rigidbody>();
        movementScript = character.GetComponent<Movemont>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && movementScript.IsGrounded())
        {
            rb.velocity = new Vector3(0, jump, 0);
            sound.Play();

        }
    }
/*
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Flooor"){
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Flooor"){
            isGrounded = false;
        }
    }*/
}
