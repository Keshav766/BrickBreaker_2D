using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{

    [SerializeField] int points = 1;

   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ScoreHandler.instance.IncreaseScore(points);
            Destroy(gameObject);
        }
    }


}
