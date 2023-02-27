using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    public string type;

    private bool buttonPressed = false;

    private Vector3 direction = Vector3.up;
    private float range = 0.6f;

    void Update()
    { 
        //Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));
    }


    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "ActivePlayer" && type == "door") { 
            GameEvents.current.DoorTriggerEnter(id);
        }
        if (type == "button" && !buttonPressed)
        {
            GameEvents.current.ButtonTriggerEnter(id);
            buttonPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (type == "button" && buttonPressed) 
        {
            Ray theRay = new(transform.position, transform.TransformDirection(direction * range));
            if (!Physics.Raycast(theRay, out RaycastHit hit, range))
            {
                GameEvents.current.ButtonTriggerExit(id);
                buttonPressed = false;
            }
        }
    }
}
