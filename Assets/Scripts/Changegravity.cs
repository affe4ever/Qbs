using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity : MonoBehaviour
{
    private bool isChanged = false;
    private float force = 9.8f;
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if (isChanged) {
                Physics.gravity = new Vector3(0, -force, 0);
                isChanged = false;
            }
            else
            {
                Physics.gravity = new Vector3(0, force, 0);
                isChanged = true;
            }
            //character.gravity = new Vector3(0, force, 0);
            //Physics.gravity = new Vector3(0, -force, 0);   
        }
    }
}
