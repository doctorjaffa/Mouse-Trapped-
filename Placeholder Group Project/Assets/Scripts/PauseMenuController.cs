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
        audiosource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                UnPauseGameOnDown();
                audiosource.volume = 1f;
            }
            else
            {
                PauseGameOnDown();
                audiosource.volume = 0f;
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
