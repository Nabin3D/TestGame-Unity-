using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	public Vector3 cameraOffset;


	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		cameraOffset = new Vector3 (0, 1, -15);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + cameraOffset;


	}
}
