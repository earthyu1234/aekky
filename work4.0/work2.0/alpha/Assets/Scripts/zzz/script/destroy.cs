using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}