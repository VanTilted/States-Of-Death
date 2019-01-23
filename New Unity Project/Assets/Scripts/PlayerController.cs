using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public Rigidbody theRB;
    public float jumpForce;
    private bool facingRight;
    public AudioSource AudioS;
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
        facingRight = true;
     
    }

    // Update is called once per frame
    void Update()
    {
        PlayerFootsteps();
        float move = Input.GetAxis("Horizontal");
        theRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(move * theRB.velocity.x, jumpForce, theRB.velocity.z);
        }





        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();
            void Flip()
            {
             facingRight = !facingRight;
             Vector3 theScale = transform.localScale;
             theScale.z *= -1;
            transform.localScale = theScale;
            }
         void PlayerFootsteps()
        {
            if(moveSpeed > 0.1f)
            {
                AudioS.enabled = true;
                AudioS.loop = true;
            }

            if (moveSpeed < 0.1f)
            {
                AudioS.enabled = false;
                AudioS.loop = false;
            }
        }
    }
}
