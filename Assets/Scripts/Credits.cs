using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text highScoreText;

    void Start()
    {
        Debug.Log("In Credits");
        playerScoreText.text = DataManager.player_Name + " - " + Score.score.ToString();
        highScoreText.text = DataManager.high_Score_Player + " - " + DataManager.high_Score.ToString();
    }
    public void Retry()
    {
        Debug.Log("Retrying in Progress . . .");
        DataManager.lives = 3;
        Debug.Log(DataManager.lives + " lives remaining!");
        SceneManager.LoadScene(1);
        GameManager.isGameOver = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        GameManager.isGameOver = false;
    }
}
