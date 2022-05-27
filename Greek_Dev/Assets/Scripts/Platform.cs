using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity += Vector2.down * speed;

    }
    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3(0, speed * Time.deltaTime);
    }
}
