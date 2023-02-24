using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_movement : MonoBehaviour
{
    public GameObject character;
    private CharacterController controller;
    public float gravity = 5.0f;
    public float playerSpeed = 2.0f;


    private Vector3 moveGravity = new Vector3(0, 0, 0);


    private Vector3 directionDown;
    

    // Start is called before the first frame update
    void Start()
    {
        controller = character.GetComponent<CharacterController>();

        FlipGravity(Vector3.down);
    }

    // Update is called once per frame
    void Update(){
        Walk();
    }

    void FixedUpdate()
    {
        ApplyGravity();
    }

    void Walk(){
        //Vector3.forward is towards A

        //A D
        float x = Input.GetAxis("Horizontal");
        //W S
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(z, 0, -x);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }

    //gravity can only be used along the y-axis
    void ApplyGravity(){
        
        if (!OnFloor()){
            if (Mathf.Abs(moveGravity[1]) < gravity)
                moveGravity = moveGravity + directionDown * Time.deltaTime * 0.1f;
            else moveGravity = directionDown * Time.deltaTime * gravity;
        } else moveGravity = new Vector3(0, 0, 0);
        print(OnFloor() + "  " + moveGravity);
        controller.Move(moveGravity);
    }

    public void FlipGravity(){
        if (directionDown != Vector3.down) FlipGravity(Vector3.down);
        else FlipGravity(Vector3.up);
    }

    private void FlipGravity(Vector3 direction){
        directionDown = transform.TransformDirection(direction);
    }

    public bool OnFloor(){
        return Physics.Raycast(transform.position, directionDown, 0.6f);
    }
}
