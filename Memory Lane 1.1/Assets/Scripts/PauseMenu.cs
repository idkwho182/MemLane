using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // if user presses the P key while the game is running it will pause. If the game is already paused the p key will resume the game
    void Update() { 
        if (Input.GetKeyDown(KeyCode.P)){

            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        // This unpauses the game and sets the speed of the game back to normal 
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        // Pauses the game by setting the speed of the game to 0 
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        // Quits out of the application
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
