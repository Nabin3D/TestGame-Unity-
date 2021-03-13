using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailMovement : MonoBehaviour {


//	private Rigidbody2D enimRB;

	public Transform collisionCheck;

	public float moveSpeed;

	private bool moveRight;
	public float groundDistance;

	private Animator myAnim;

//	private bool canMove;


	// Use this for initialization
	void Start () {

//		enimRB = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();


		moveRight = true;
//		canMove = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		

//
//		if (canMove) {
//			if (moveRight) {
//				enimRB.velocity = new Vector2 (-moveSpeed * Time.deltaTime, enimRB.velocity.y);
			
//			}
//		}



		transform.Translate (Vector2.left * moveSpeed * Time.deltaTime);

		RaycastHit2D hitInfo = Physics2D.Raycast (collisionCheck.position, Vector2.down, groundDistance);
		Debug.DrawRay (collisionCheck.position, Vector2.down, Color.red, 1f);

		if (hitInfo.collider == false) {
			if (moveRight == true) {
				transform.eulerAngles = new Vector3 (0, -180, 0);
				moveRight = false;

			} else {
				transform.eulerAngles = new Vector3 (0, 0, 0);
				moveRight = true;
			}
			
		}







		
	}

















}//
