using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changegravity_CharacterController : MonoBehaviour
{
    
    public GameObject character;
    private CharacterController_movement movementScript;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = character.GetComponent<CharacterController_movement>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && movementScript.OnFloor()) {
            movementScript.FlipGravity();
            sound.Play();
        }

    }

    void FixedUpdate() {

    }
}
