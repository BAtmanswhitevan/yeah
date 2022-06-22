using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool r;
    private bool l;
    public float walkSpeed;
    public float sprintMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            r = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            r = false;
        }
        if (r == true)
        {
            rb.AddForce(Vector2.right * walkSpeed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            l = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            l = false;
        }
        if (l == true)
        {
            rb.AddForce(Vector2.left * walkSpeed);
        }
    }
}
