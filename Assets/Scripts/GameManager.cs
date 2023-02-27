using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;
    public static bool isPaused = false;

    [SerializeField] private Rotator rotator;
    [SerializeField] private PinSpawner spawner;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    private void Pause()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
        spawner.enabled = false;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
        spawner.enabled = true;
    }
    public void GameOver()
    {
        if (isGameOver)
            return;
        DataManager.lives--;
        FindObjectOfType<Lives>().UpdateLives();
        Debug.Log(DataManager.lives);
        isGameOver = true;
        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("GameOver");
        //Debug.Log("Game Over!");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isGameOver = false;
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Credits()
    {
        Debug.Log("Going to Credits . . .");
        SceneManager.LoadScene(2);
    }
}
