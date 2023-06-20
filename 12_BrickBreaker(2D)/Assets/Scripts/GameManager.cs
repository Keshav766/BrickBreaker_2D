using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject[] powerUpPrefabs;

    public bool gameStarted = false;
    public bool gameOver = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void GameStart()
    {
        UIHandler.instance.GameStart();

        FindObjectOfType<Ball>().StartBallMovement();
    }

    public void GameOver()
    {
        gameOver = true;

        UIHandler.instance.GameOver();
    }

    public void ReloadLevel()
    {
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currIndex);

        UIHandler.instance.GameStart();
    }

    public void SpawnPoints(Vector3 tilePosition)
    {
        int randomInt = Random.Range(0, powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[randomInt], tilePosition, Quaternion.identity);
    }
}
