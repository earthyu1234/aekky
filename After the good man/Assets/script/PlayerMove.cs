using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public Vector3 targetPosition;
    Animator anim;
    int walkHash = Animator.StringToHash("Walk");
    bool facingRight = false;
    bool Walking = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            anim.SetTrigger(walkHash);
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            anim.SetBool("Walking", true);

        }


        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
        Vector3 theScale = transform.localScale;
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        float WorldXPos = Camera.main.ScreenToWorldPoint(pos).x; 

        if (WorldXPos > gameObject.transform.position.x)
        {
            theScale.x = 1;
            transform.localScale = theScale;
        }

        else
        {
            theScale.x = -1;
            transform.localScale = theScale;
        }
    }
   

}
