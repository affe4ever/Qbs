using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoor : MonoBehaviour
{
  
    
    public bool open;
    public int pressed;
    public int amount;
    public bool yes;
    private  GameObject trigger;

    private int times;

    // Start is called before the first frame update
    void Start()
    {
        
        yes = false;
        if (open){
            OpenDoor();
        }
    }

    // Update is called once per frame
    void Update()
    {
  
        if (!open && amount == pressed)
        {
            OpenDoor();            
        }
        else if (open && amount != pressed)
        {
            CloseDoor();
        }

    }

    // funkar inte just nu
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ActivePlayer" && open)
        {
            yes = true;
        }
    }

    private void OpenDoor()
    {
        times = 1;
        open = true;
        this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.green;
        this.gameObject.transform.GetChild(1).localPosition = new Vector3(0, 0, +1.0f);
        this.gameObject.transform.GetChild(2).localPosition = new Vector3(0, 0, -1.0f);
    }

    private void CloseDoor()
    {
        open = false;
        this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.red;
        this.gameObject.transform.GetChild(1).position -= new Vector3(0, 0, 1.6f);
        this.gameObject.transform.GetChild(2).position += new Vector3(0, 0, 1.6f);
    }

}
