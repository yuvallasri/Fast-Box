using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment movment;
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("WE HIT SOMETHING!");
        //Debug.Log(collision.collider.name);
        if (collision.collider.gameObject.tag == "Obstacle")
        {
            movment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    // Start is called before the first frame update

}
