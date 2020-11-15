using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickScript : MonoBehaviour
{
    public void startGameButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void settingsButton()
    {
        Debug.Log("We'll add something in here after");
    }
}
