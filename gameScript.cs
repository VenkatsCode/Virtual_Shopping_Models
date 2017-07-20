using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	public GameObject[] gameobjectArray;
	private Vector3[] gameobjectInitialPositionArray = new Vector3[100];
	private int score = 0;
	void Start () {
		initialPosition ();
		Debug.Log("gameobjectArray: "+gameobjectArray.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			calculateScore ();
			resetPosition ();
		}
			
	}

	 void initialPosition(){

		for(int i=0; i<gameobjectArray.Length; i++)
		{
			Debug.Log(i);
			Debug.Log("gameobjectArray: "+gameobjectArray [i].transform.position);
			gameobjectInitialPositionArray [i] = gameobjectArray [i].transform.position;
		}

	}

	void resetPosition(){

		for(int i=0; i<gameobjectArray.Length; i++)
		{
			Debug.Log(i);
			gameobjectArray [i].transform.position = gameobjectInitialPositionArray [i];
		}
		score = 0;
	}

	void calculateScore(){

		for(int i=0; i<gameobjectArray.Length; i++)
		{
			if (gameobjectArray [i].transform.position != gameobjectInitialPositionArray [i]) {
				score = score + 1;
			}
			Debug.Log("score is: "+score);
		}
	}

}
