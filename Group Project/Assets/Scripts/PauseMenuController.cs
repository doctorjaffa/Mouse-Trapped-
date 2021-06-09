using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public static bool isPaused;
    public GameObject PauseMenu;
    AudioSource audiosource;
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    void Start()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                UnPauseGameOnDown();
            }
            else
            {
                PauseGameOnDown();
            }
        }
    }

    void PauseGameOnDown()
    {
        isPaused = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }

    void UnPauseGameOnDown()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        
    }

}
