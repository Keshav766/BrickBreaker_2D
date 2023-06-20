using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float startForce = 10f;

    Rigidbody2D ballRbRef;
    Vector2 initialVeclo;



    void Start()
    {
        ballRbRef = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // CheckBallVelocity();
    }



    public void StartBallMovement()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), 1);
        ballRbRef.AddForce(randomDirection.normalized * startForce, ForceMode2D.Impulse);

        GameManager.instance.gameStarted = true;

        initialVeclo = ballRbRef.velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "death")
        {
            GameManager.instance.GameOver();
        }
    }

    void CheckBallVelocity()
    {
        if(GameManager.instance.gameStarted)
        {
            if(ballRbRef.velocity.magnitude < initialVeclo.magnitude)
            {
                ballRbRef.velocity = initialVeclo;
            }
        }
    }
}
