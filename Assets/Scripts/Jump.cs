using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rb;
    public bool isGrounded;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {   
        isGrounded = true;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(0, jump, 0);
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
