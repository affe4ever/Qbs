using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity : MonoBehaviour
{
    public bool isSpacePressed;
    public bool gravityReversed;
    public bool isGrounded;
    private float force = 9.8f;
    public GameObject character;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        gravityReversed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            isSpacePressed = true;
        }
        else{
            isSpacePressed = false;
        }
    }

    void FixedUpdate() {
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
        }
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
}
