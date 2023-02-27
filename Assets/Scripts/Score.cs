using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;
    [SerializeField] private Text playerNameText;
    [SerializeField] private Text livesText;

    private void Start()
    {
        score = 0;
        highScoreText.text = DataManager.high_Score_Player + " - " + DataManager.high_Score.ToString();
        playerNameText.text = DataManager.player_Name;
    }
    public void UpdateScore()
    {
        if (GameManager.isGameOver == false)
        {
            score++;
            scoreText.text = score.ToString();
        } else 
        {
            if (score > DataManager.high_Score)
            {
                DataManager.high_Score = score;
                DataManager.high_Score_Player = DataManager.player_Name;
            }
        }
    }
}
