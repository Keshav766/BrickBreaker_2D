using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStrikerMovement : MonoBehaviour
{
    Rigidbody2D playerRbRef;

    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        playerRbRef = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MoveOnInput();
    }

    void MoveOnInput()
    {
        if (Input.GetMouseButton(0) && !GameManager.instance.gameOver)
        {
            Vector2 tapPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (tapPos.x < 0)
            {
                ApplyForce(Vector2.left);
            }
            else if (tapPos.x > 0)
            {
                ApplyForce(Vector2.right);
            }
        }
        else
        {
            playerRbRef.velocity = Vector2.zero;
        }
    }

    void ApplyForce(Vector2 direction)
    {
        playerRbRef.AddForce(moveSpeed * direction * Time.deltaTime, ForceMode2D.Impulse);
    }

  

}
