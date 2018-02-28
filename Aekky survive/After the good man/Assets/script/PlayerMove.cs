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
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            anim.SetTrigger(walkHash);
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            anim.SetBool("Walking", true);
            
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 3);
        


    }

   
}