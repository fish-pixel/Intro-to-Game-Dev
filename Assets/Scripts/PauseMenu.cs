using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1.0f;

            //Hides the button when the game is unpaused
            pauseUI.SetActive(false);

            //When isPaused is true, this line will set it to false
            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0.0f;

            //Shows button when the game is paused
            pauseUI.SetActive(true);

            //When isPaused is false, this line will set it to true
            isPaused = true;
        }
        //Sets isPaused to the opposite of what it is right now
        //isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
