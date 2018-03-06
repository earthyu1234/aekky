using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtrigger : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public float speed = 0;


    Vector3 lastPosition = Vector3.zero;
    void FixedUpdate()
    {
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
        if (speed > 0.008)
        {
            anim.SetBool("Walking", true);
        }
        if (speed < 0.002)
        {
            anim.SetBool("Walking", false);
        }


    }

}
