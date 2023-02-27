using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] private Text livesText;
    public void Start()
    {
        livesText.text = DataManager.lives.ToString();
    }
    public void UpdateLives()
    {
        livesText.text = DataManager.lives.ToString();
        Debug.Log(DataManager.lives + " lives");
    }
}
