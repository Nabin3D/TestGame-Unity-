using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : MonoBehaviour {

	public bool moveRight;

	public float moveForce;
	public float destroyTimer;

	// Use this for initialization

	void Start () {
		
	}


	// Update is called once per frame
	void Update () {	
		
		MoveKnife ();
		SelfDestroy ();
	}




	public void MoveKnife(){
		
		if (moveRight) { // if move right is false  then move left  ;
			Vector3 temp = transform.position;//  create temporary move position to cureent position 
			temp.x += moveForce * Time.deltaTime;  // temp position increace with move force and every frame 
			transform.position = temp;  //  current position is euals to temp position  

		} else {
			Vector3 temp = transform.position;
			temp.x -= moveForce * Time.deltaTime;
			transform.position = temp;
		}
	}



	public void SelfDestroy (){
		Destroy (gameObject,destroyTimer );
	}







}// class

