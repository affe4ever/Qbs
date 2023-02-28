using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    private Canvas canvasObject;
    // Start is called before the first frame update
    void Start()
    {
        canvasObject = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            canvasObject.enabled = false;
        }
    }
}
