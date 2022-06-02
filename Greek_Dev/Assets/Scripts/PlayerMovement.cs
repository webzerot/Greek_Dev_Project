using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float PlayerSpeed;
    [SerializeField] float minX, maxX;
    [SerializeField] float JumpForce = 10;
    [SerializeField] string PlatformTag = "Platform";


    void Start()
    {
        Jump();
    }

    //private bool isGrounded;
    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX * PlayerSpeed * Time.deltaTime, 0);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y);
        }


        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y);
        }

        if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PlatformTag))
        {
            Jump();
        }
    }


    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }
}
