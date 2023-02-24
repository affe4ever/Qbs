using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCube : MonoBehaviour
{


    public Camera cam;

    public Transform focus;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    // Start is called before the first frame update
    void Start()
    {
        //focus = cube1.Rigidbody;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {            
            if(cube1 != null)
            {
                Switch(cube1); 
            }           
        }
        else if(Input.GetKey(KeyCode.Alpha2))
        {
            if(cube2 != null)
            {
               Switch(cube2); 
            }           
        }
        else if(Input.GetKey(KeyCode.Alpha3))
        {
            if(cube3 != null)
            {
                Switch(cube3); 
            }    
        }
    }

    void Switch(GameObject cube)
    {
        if (cube == cube1)
        {
            cube1.GetComponent<Movemont>().enabled = true;
            cube2.GetComponent<Movemont>().enabled = false;
            cube3.GetComponent<Movemont>().enabled = false;
        }
        else if (cube == cube2)
        {
            cube1.GetComponent<Movemont>().enabled = false;
            cube2.GetComponent<Movemont>().enabled = true;
            cube3.GetComponent<Movemont>().enabled = false;
        }
        else if (cube == cube3)
        {
            cube1.GetComponent<Movemont>().enabled = false;
            cube2.GetComponent<Movemont>().enabled = false;
            cube3.GetComponent<Movemont>().enabled = true;
        }
        
        
    }
}
