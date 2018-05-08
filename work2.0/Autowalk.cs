using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autowalk : MonoBehaviour {

	public float  moveSpeed = 0.1f;


	// Use this for initialization

	
	void Update () {

	gameObject.transform.position += new Vector3( moveSpeed , 0 , 0);

		if (gameObject.transform.position.x >= 1.5f )
		{

		moveSpeed = 0;

		} 
	}

}

