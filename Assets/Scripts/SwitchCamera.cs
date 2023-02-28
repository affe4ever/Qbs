using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    
    //private List<GameObject> cameras = new List<GameObject>();
    public Camera active;
    //public int id;

    // Start is called before the first frame update
    void Start()
    {

        //cameras.AddRange(GameObject.FindGameObjectsWithTag("camPosition"));
  
        //id = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {   
            if (id != cameras.Count)
            {
                id++;
                active.transform.position = cameras[id].transform.position;
            }    
            
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (id != 0)
            {
                id--;
                active.transform.position = cameras[id].transform.position; 
            }
                
        }*/
    }

    public void ChangeCamera (Vector3 placement)
    {
        active.transform.position = placement; 
    }

    

}
