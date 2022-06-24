using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void HowToPlayButton()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
