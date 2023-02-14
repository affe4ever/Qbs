using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    public string type;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player" && type == "door") { 
            GameEvents.current.DoorTriggerEnter(id);
        }
        if (type == "button")
        {
            GameEvents.current.ButtonTriggerEnter(id);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (type == "button") 
        {
            GameEvents.current.ButtonTriggerExit(id);
        }
    }
}
