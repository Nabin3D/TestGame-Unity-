using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Image img;

	// color section
	[Range(0f,255f)]
	public float R;

	[Range(0f,255f)]
	public float G;

	[Range(0f,255f)]
	public float B;




	private Rigidbody2D playerRB;
	private SpriteRenderer playerSP;

	private float inputHorizontal;
	private float inputVerticle;
	public float distance;
	public LayerMask whatisLadder , ground; // for layer mask check 
	private bool isClimbing;

	public float climbSpeed;
	public float jumpForce;  //  varriable to jump force 
	private bool isGrounded; //  for ground check collision  
	public float groundDistance;


	void Awake(){
		playerRB = GetComponent<Rigidbody2D> (); // get the player Rigidbody component  

		playerSP = GetComponent<SpriteRenderer> ();
		playerSP.color = new Color(R,G,B);
	}


	void FixedUpdate(){  // use when working with Rigidbody physics  
		isGrounded = true;
		inputHorizontal = Input.GetAxisRaw ("Horizontal");  // Horizontal movement inputs  
		playerRB.velocity = new Vector2 (inputHorizontal * speed, playerRB.velocity.y);  // move horizontal and leqave the y direction as regid body 


		RaycastHit2D hitinfo = Physics2D.Raycast (transform.position, Vector2.up, distance, whatisLadder); //  check raycat hit to the Ladder mask object
		RaycastHit2D groundInfo = Physics2D.Raycast (transform.position, Vector2.down, groundDistance, ground); // check the Hit info of Ground  

		if (hitinfo.collider != null) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				isClimbing = true;		
			}
		} else {
			isClimbing = false; // when isclimbing is False the gravity scale increased and player falles down 
		}



		if (isClimbing == true) { // the climbing is true when  collider hit info mation is  equals to  Ladder mask object  
			inputVerticle = Input.GetAxisRaw ("Vertical"); // give the input 
			playerRB.velocity = new Vector2 (playerRB.velocity.x, inputVerticle * climbSpeed); //  climbing the ladder  
			playerRB.gravityScale = 0;

		} else {
			playerRB.gravityScale = 5;
		}


		if (isGrounded == true && groundInfo.collider != null) {
			Jump ();
			isGrounded = false;
		}

		ResetScene ();

		playerSP.color = new Color(R,G,B);


	}// Update Class 



	public void Jump(){		
		if (Input.GetButtonDown ("Jump")) { // "Jump" is the name of the input  
			playerRB.velocity = new Vector2 (playerRB.velocity.x, jumpForce); //  player velocity to Y direction is equal to  "Jump Force "  

			return ;
		}
	}// jump method 





	public void ResetScene(){  // Reset the scene of the game play  
		if(Input.GetKeyDown(KeyCode.Escape)){ // Key input by controller 
			SceneManager.LoadScene ("Main Scene");  // reset the Scene scene by name  
			
			
		}
		
	}







} //class

