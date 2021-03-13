using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

	public GameObject knife,knife2;
	private float maxY = 3.8f, minY = -3.2f;
	Vector2 position;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartSpawning());



//		float Ymap = (Random.Range (maxY, minY));
//
//		position = new Vector2 (0, Ymap);
//
//		for (int i = 0; i < 10; i++) {
//
//			Instantiate (knife,position, Quaternion.identity);
//
//
//
//			Debug.Log ("instantiate" + i);
//
//		}		
	}

	
	// Update is called once per frame
	void Update () {	
		float Y = (Random.Range (maxY, minY));	
	}




	IEnumerator StartSpawning(){
		yield return new WaitForSeconds (Random.Range (2f, 4f));

		Instantiate (knife);
		Instantiate (knife2);

		float y = Random.Range (minY, maxY);
		float Yup = Random.Range (maxY, minY);
		knife.transform.position = new Vector2 (transform.position.x ,  y);
		knife2.transform.position = new Vector2 (transform.position.x, Yup);

		StartCoroutine (StartSpawning());
		
	}



}
