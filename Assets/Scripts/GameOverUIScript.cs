using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIScript : MonoBehaviour
{
    public Button mainMenuButton;
    public Button retryButton;
    public Button creditsButton;
    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        retryButton.onClick.AddListener(Retry);
        creditsButton.onClick.AddListener(ToCredits);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
    public void ToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
