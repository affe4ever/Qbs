using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemont : MonoBehaviour
{
	public float speed = 2.0f;
	public GameObject character;
	public bool isRight;
	public bool isLeft;
	public bool isForward;
	public bool isBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


	void Update () {
		
		if (Input.GetKey(KeyCode.UpArrow)){
			isForward = true;
		}
		else{
			isForward = false;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			isBack = true;
		}
		else{
			isBack = false;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			isLeft = true;
		}
		else{
			isLeft = false;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
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
}
/*
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.left* speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.back* speed * Time.deltaTime;
		}
        
*/