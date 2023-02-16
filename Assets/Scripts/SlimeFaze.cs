using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeFaze : MonoBehaviour
{
    public Movemont Movemont;
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
            Movemont.speed = 1.0f;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Slime"){
            Movemont.speed = 2.0f;
        }
    }
}
