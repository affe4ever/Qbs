using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeFaze : MonoBehaviour
{
    public Movemont movemont;
    public Rigidbody rb;
    public AudioSource walking;
    public AudioSource fazing;

    // Start is called before the first frame update
    void Start()
    {       
        Physics.IgnoreLayerCollision(6, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Slime"){
            movemont.speed = 1.0f;
            fazing.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Slime"){
            movemont.speed = 2.0f;
            fazing.Pause();
        }
    }
}
