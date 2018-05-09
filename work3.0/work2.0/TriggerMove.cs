using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMove : MonoBehaviour {

	public float  moveSpeed = 0.1f;
	public GameObject MoveP;




	void Start () 
 {
  
 }
  




	void Update () {

	MoveP.transform.position += new Vector3( moveSpeed , 0 , 0);

		if (MoveP.transform.position.x >= 1.5f )
		{

		moveSpeed = 0;

		} 
	}
}
