using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Gets active scene build indext and adds 1 loading level 1
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
