using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity : MonoBehaviour
{
    public bool isSpacePressed;
    public bool gravityReversed;
    public bool isGrounded;
    public float force = 9.8f;
    public GameObject character;
    public Rigidbody rb;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        gravityReversed = false;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
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

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Flooor"){
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Flooor"){
            isGrounded = false;
        }
    }

    void Gravity()
    {
        if (gravityReversed){
            gravityReversed = false;
            rb.velocity = new Vector3(0, -force, 0);
            rb.useGravity= true;

        }
        else if (!gravityReversed) {
            rb.useGravity=false;
            rb.velocity = new Vector3(0, force, 0);
            gravityReversed = true;
        }
    }
}
