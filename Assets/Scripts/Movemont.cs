using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemont : MonoBehaviour
{
	public float speed = 2.0f;
	private GameObject character;
	public bool isRight;
	public bool isLeft;
	public bool isForward;
	public bool isBack;

	private Vector3 directionDown;
	public Vector3 cam;

    // Start is called before the first frame update
    void Start()
    {
		character = this.gameObject;
        FlipGravityRaycast(Vector3.down);
    }

    // Update is called once per frame


	void Update () {
		//print(IsGrounded());
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
			isForward = true;
		}
		else{
			isForward = false;
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
			isBack = true;
		}
		else{
			isBack = false;
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
			isLeft = true;
		}
		else{
			isLeft = false;
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
			isRight = true;
		}
		else {
			isRight = false;
		}

	}
    

	void FixedUpdate(){
		if (isForward){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (isBack){
			transform.position += Vector3.left* speed * Time.deltaTime;
		}
		if (isLeft){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (isRight){
			transform.position += Vector3.back* speed * Time.deltaTime;
		}
	}


	public void FlipGravityRaycast(Vector3 direction){
        directionDown = transform.TransformDirection(direction);
    }
	public bool IsGrounded(){
        return Physics.Raycast(transform.position, directionDown, 0.6f);
    }
}