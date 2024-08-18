using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float HorizontalInput,speed,jumpForce;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        if(HorizontalInput!=0 )
        {
            rb.velocity=new Vector2(HorizontalInput*speed,rb.velocity.y);
        }
        if(isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(0, jumpForce);
        }
        if (transform.position.y < -12)
            Application.LoadLevel("SampleScene");
    }
}
