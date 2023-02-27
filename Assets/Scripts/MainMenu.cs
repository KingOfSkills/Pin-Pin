using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Text playerNameText;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DataManager.lives = 3;
        //Debug.Log(DataManager.lives + " lives");
        GameManager.isGameOver = false;
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void DisplayName()
    {
        playerNameText.text = DataManager.player_Name;
    }
    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
}
