using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity : MonoBehaviour
{

    private float speed = 2.0f;
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
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
