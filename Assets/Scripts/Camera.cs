using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject controller;
    
    private SwitchCube thing;
    
    
    // Start is called before the first frame update
    void Start()
    {
        thing = controller.GetComponent<SwitchCube>();
    }
    
   
    
    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(thing.focus);
        
    }

    
}
