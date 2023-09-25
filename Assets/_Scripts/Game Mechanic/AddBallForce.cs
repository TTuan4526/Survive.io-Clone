using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallForce : MonoBehaviour
{
    public GameObject ball;
    public bool left, right, up, down;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (left)
            {
                ball.GetComponent<Rigidbody2D>().AddForce(-transform.right * 500);
            }
            else if (right)
            {
                ball.GetComponent<Rigidbody2D>().AddForce(transform.right * 500);
            }
            else if (up)
            {
                ball.GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
            }
            else if (down)
            {
                ball.GetComponent<Rigidbody2D>().AddForce(-transform.up * 500);
            }
        }
    }
}
