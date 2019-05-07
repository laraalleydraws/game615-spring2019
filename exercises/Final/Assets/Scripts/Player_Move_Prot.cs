using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;


    //int jumpsRemaining = 5;
    //int jumpCount = 5;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        PlayerMove ();

        //if (isGrounded)
        //{
        //    jumpsRemaining = jumpCount;
        //}
    }
    void PlayerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown ("Jump"))// && jumpsRemaining > 0)
        {
            //jumpsRemaining--;//jumpsRemaining = jumpsRemaining - 1
            Jump();
        }
        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump()
    {
        //JUMP
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);

    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Player has collided with " + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }

    }
    void PlayerRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        if (hit.collider != null && hit.distance < 0.9f && hit.collider.tag == "enemy")
        {
            Debug.Log("something happened");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200);
            hit.collider.gameObject.GetComponent<BoxCollider>().enabled = false;
            hit.collider.gameObject.GetComponent<EnemyMove>().enabled = false;
        }
        if (hit.collider != null && hit.distance < 0.9f && hit.collider.tag != "enemy")
        {
            isGrounded = false;
        }
        {
            Debug.Log("squished");
        }
    }
}
