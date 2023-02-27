using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<TestDoor>().amount ++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "ActivePlayer" || other.gameObject.tag == "Interactable" || other.gameObject.tag == "Player")
        {
            door.GetComponent<TestDoor>().pressed ++;
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "ActivePlayer" || other.gameObject.tag == "Interactable" || other.gameObject.tag == "Player")
        {
            door.GetComponent<TestDoor>().pressed --;
        }
    }
}
