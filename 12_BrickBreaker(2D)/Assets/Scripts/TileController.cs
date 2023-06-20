using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            int randomInt = Random.Range(0, 11);
            if (randomInt < 5)
            {
                GameManager.instance.SpawnPoints(transform.position);
            }

            ScoreHandler.instance.IncreaseScore(1);

            Destroy(gameObject);
        }
    }
}
