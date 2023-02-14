using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_movement : MonoBehaviour
{
    public GameObject character;
    private CharacterController controller;
    private float playerSpeed = 2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        if (character != null)
            controller = character.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //A D
        float x = Input.GetAxis("Horizontal");
        //W S
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(z, 0, -x);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }
}
