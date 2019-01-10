using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private new GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        GameState.gamePaused = false;
        GameState.correctCode = false;
        GameState.canOpenDoor = new Dictionary<string, bool>();
        GameState.switchOn = false;
        canvas = GameObject.Find("CanvasPause");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameState.inKeypad)
        {
            if (GameState.gamePaused)
            {
                canvas.SetActive(false);
                GameState.gamePaused = false;
            }
            else
            {
                canvas.SetActive(true);
                GameState.gamePaused = true;
            }
        }
    }

    public void Resume()
    {
        canvas.GetComponent<AudioSource>().Play();
        canvas.SetActive(false);
        GameState.gamePaused = false;
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
