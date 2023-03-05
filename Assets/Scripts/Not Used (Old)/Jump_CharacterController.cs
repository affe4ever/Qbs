using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_CharacterController : MonoBehaviour
{
    public GameObject character;
    private CharacterController controller;
    private CharacterController_movement movementScript;
    public float jumpPower = 7.0f;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {   
        sound = GetComponent<AudioSource>();

        controller = character.GetComponent<CharacterController>();
        movementScript = character.GetComponent<CharacterController_movement>();
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Space) && movementScript.OnFloor())
        {
            controller.Move(new Vector3(0, jumpPower, 0));
            sound.Play();

        }
    }
}
