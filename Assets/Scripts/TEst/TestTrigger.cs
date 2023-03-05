using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    private TestDoor door;
    
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponentInParent<TestDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ActivePlayer")
        {
            door.canGoTrough = true;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
if (other.gameObject.tag == "ActivePlayer")
        {
            door.canGoTrough = false;
            
        }
    }
}
