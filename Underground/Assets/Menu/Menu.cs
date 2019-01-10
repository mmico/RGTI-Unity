using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
