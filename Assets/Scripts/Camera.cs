using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject controller;
    //public Transform target;
    private SwitchCube thing;
    //public Transform focus;
    
    // Start is called before the first frame update
    void Start()
    {
        thing = controller.GetComponent<SwitchCube>();
    }
    
   
    
    // Update is called once per frame
    void Update()
    {
        //focus = controller.SwitchCube.focus;
        transform.LookAt(thing.focus);
        
    }

    
}
