using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{

    public static UIHandler instance;

    [SerializeField] GameObject titlePanelRef;
    [SerializeField] GameObject gameOverPanelRef;
    [SerializeField] TextMeshProUGUI scoreTextRef;
    [SerializeField] GameObject Tiles;

    int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GameStart()
    {
        titlePanelRef.SetActive(false);
        Tiles.SetActive(true);
    }

    public void GameOver()
    {
        scoreTextRef.text = ScoreHandler.instance.score.ToString();
        gameOverPanelRef.SetActive(true);
    }



}
