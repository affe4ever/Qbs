using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity : MonoBehaviour
{
    //public bool isSpacePressed;
    //public bool isGrounded;
    public bool gravityReversed;
    public float force = 9.8f;
    public GameObject character;
    private Rigidbody rb;
    private Movemont movementScript;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        gravityReversed = false;
        sound = GetComponent<AudioSource>();
        rb = character.GetComponent<Rigidbody>();
        movementScript = character.GetComponent<Movemont>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && movementScript.IsGrounded()) {
            Gravity();
            sound.Play();
            //isSpacePressed = true;
        }

        if(gravityReversed)
        {
            rb.velocity = new Vector3(0, force, 0);
        }
        /*else{
            isSpacePressed = false;
        }*/
    }

    void FixedUpdate() {

        /*
        if (isSpacePressed){
            if (gravityReversed){
                gravityReversed = false;
            }
            else {
                gravityReversed = true; 
            }
        }

        if (gravityReversed) {
            rb.velocity = new Vector3(0, force, 0);
        }*/
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

    void Gravity()
    {
        if (gravityReversed){
            gravityReversed = false;
            movementScript.FlipGravityRaycast(Vector3.down);
            rb.velocity = new Vector3(0, -force, 0);
            rb.useGravity= true;

        }
        else if (!gravityReversed) {
            rb.useGravity=false;
            movementScript.FlipGravityRaycast(Vector3.up);
            rb.velocity = new Vector3(0, force, 0);
            gravityReversed = true;
        }
    }
}
