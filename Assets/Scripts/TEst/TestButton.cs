using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    private AudioSource sound;
    public GameObject door;
    private Vector3 direction = Vector3.up;
    private float range = 0.6f;
    public bool buttonPressed = false;
    /*
    private BoxCollider BC;
    private Vector3 topRight;
    private Vector3 bottomRight;
    private Vector3 topLeft;
    private Vector3 bottomLeft;
    */

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        door.GetComponent<TestDoor>().amount ++;
        //BC = GetComponent<BoxCollider>();
        //topRight = BC.size;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, direction);
    }
    
    private void OnTriggerEnter(Collider other){

            if ((other.gameObject.tag == "ActivePlayer" || other.gameObject.tag == "Interactable" || other.gameObject.tag == "Player") && !buttonPressed)
            {
                sound.Play();
                door.GetComponent<TestDoor>().pressed++;
                buttonPressed = true;
            }
    }

    private void OnTriggerExit(Collider other){
        if ((other.gameObject.tag == "ActivePlayer" || other.gameObject.tag == "Interactable" || other.gameObject.tag == "Player") && buttonPressed)
        {
            Ray theRay = new(transform.position, transform.TransformDirection(direction * range));
            Debug.Log("yeet");
            if (!Physics.Raycast(theRay, out RaycastHit hit, range)) {
                Debug.Log("dinmamma");
                sound.Play();
                door.GetComponent<TestDoor>().pressed--;
                buttonPressed = false;
            }
            else
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name);
            }
        }
    }
}
