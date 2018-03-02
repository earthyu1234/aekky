using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectobject : MonoBehaviour {

	public Transform inventory;
	public GameObject Prefab;

	void OnTriggerEnter()
	{
		Instantiate(Prefab, inventory.position)
	}
}

