using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float PlayerSpeed;
    [SerializeField] float minX, maxX;
    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX * PlayerSpeed * Time.deltaTime, 0);

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y);
        }


        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y);
        }
    }
}
