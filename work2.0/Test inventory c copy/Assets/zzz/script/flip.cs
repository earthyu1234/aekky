using UnityEngine;
using System.Collections;

public class flip : MonoBehaviour
{

    public Vector3 targetPosition;
    Animator anim;
    int walkHash = Animator.StringToHash("Walk");
    bool facingRight = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {




        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 20);
        Vector3 theScale = transform.localScale;
        Vector3 pos = new Vector3(Input.mousePosition.x, 0, 0);
        float WorldXPos = Camera.main.ScreenToWorldPoint(pos).x;

        if (WorldXPos > gameObject.transform.position.x)
        {
            theScale.x = -1;
            transform.localScale = theScale;
        }

        else
        {
            theScale.x = 1;
            transform.localScale = theScale;
        }
    }


}