using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BoxDestroy (); // Destroy Box in Update Method  

		Debug.Log ("Hello");


	}


	public void BoxDestroy(){  //custom function  
		if (Input.GetKeyDown (KeyCode.A)) { // Input Function  
			Destroy (gameObject, 1f); // Execution 
		}
		
	}


}
