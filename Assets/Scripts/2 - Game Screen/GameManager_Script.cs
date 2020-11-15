using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Script : MonoBehaviour
{
    public static bool isPaused = false; //to control whether the game is paused
    public static bool startWave = false; //to control when the player starts the wave. We'll think better about this later on.

    /* Game controlling buttons */
    public Button pauseButton; //Object on play-screen that pauses the button.
    public Text pauseText; //This is necessary because when button is disabled, THE TEXT IS NOT. So we'll do this manually.
    public Button startWaveButton; //Object to hold the wave button. We'll make it disappear when pause is on.
    public Text startWaveText; //This is necessary because when button is disabled, THE TEXT IS NOT. So we'll do this manually.
    public Button resumeGameButton; //Object to resume game. Disappears when game unpaused.
    public Text resumeGameText; //This is necessary because when button is disabled, THE TEXT IS NOT. So we'll do this manually.
    public Button quitGameButton; //Same logic as above.
    public Text quitGameText; //This is necessary because when button is disabled, THE TEXT IS NOT. So we'll do this manually.

    public Image backgroundImage; //Backgorund image for the Unpause/Quit game button (when paused game).


    public void Start()
    {
        /* This goddamn fucking buttons don't work if you change them.
         * We had to alter MANUALLY THE FUCKING TEXTS AND FUCKING IMAGES.
         * We could've created an array as well, so there's that solution.
         */
        resumeGameButton.enabled = false;
        resumeGameButton.image.enabled = false;
        resumeGameText.text = "";
        quitGameButton.enabled = false;
        quitGameButton.image.enabled = false;
        quitGameText.text = "";
        backgroundImage.enabled = false;
    }

    public void PauseGame() //Method for the button to pause the game.
    {
        isPaused = true;
        pauseButton.enabled = false;
        startWaveButton.enabled = false;
        resumeGameButton.enabled = true;
        resumeGameButton.image.enabled = true;
        resumeGameText.text = "Resume Game";
        quitGameButton.enabled = true;
        quitGameButton.image.enabled = true;
        quitGameText.text = "Quit Game";
        backgroundImage.enabled = true;
    }

    public void StartWave() //Method to start the wave;
    {
        if (isPaused == false)
        {
            startWave = !startWave;
            Debug.Log(startWave);
        }
        else
        {
            Debug.Log("Game is paused.");
        }
    }

    public void UnpauseGame()
    {
        /* This method unpauses the game and enables/disables important buttons */
        isPaused = false;
        pauseButton.enabled = true;
        startWaveButton.enabled = true;
        resumeGameButton.enabled = false;
        resumeGameButton.image.enabled = false;
        resumeGameText.text = "";
        quitGameButton.enabled = false;
        quitGameButton.image.enabled = false;
        quitGameText.text = "";
        backgroundImage.enabled = false;
    }

    public void QuitGame()
    {
        Debug.Log("You quit the game");
        Application.Quit();
    }
}
