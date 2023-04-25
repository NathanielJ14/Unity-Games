using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpHeight;
    private bool canJump = true;

    
    void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
    
}



