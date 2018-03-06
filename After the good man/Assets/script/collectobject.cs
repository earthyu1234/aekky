using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectobject : MonoBehaviour {

	public Transform inventory;
	public GameObject Prefab;

	void OnTriggerEnter()
	{
        Instantiate(Prefab, inventory.position);
	}

    private void Instantiate(GameObject prefab, Vector3 position)
    {
        throw new NotImplementedException();
    }
}

