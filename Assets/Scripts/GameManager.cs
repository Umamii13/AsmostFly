using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int playerlife;
    float calculatescor;
    public int score;
    public int hightScore;

    public bool GameOver;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
        hightScore = PlayerPrefs.GetInt("HightScore");
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            return;
        }
        else
        {
            calculatescor += (GameSpeedManager.instance.speed/2) * Time.deltaTime;
            score = Convert.ToInt32(calculatescor);

            if (playerlife <= 0)
            {
                GameOver = true;
                if(score > hightScore)
                {
                    hightScore = score;
                    PlayerPrefs.SetInt("HightScore",hightScore);
                }
                UIManager.Instance.ShowGameOver();
                Time.timeScale = 0;
            }


        } // can Update
    }
}
