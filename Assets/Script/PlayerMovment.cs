using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float Force = 2000f;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello" + name);
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (transform.position.y < -10)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        

    }
}
