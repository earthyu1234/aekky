using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unbreak : MonoBehaviour
{


    void Awake()
    {

        DontDestroyOnLoad(transform.gameObject);

    }


}