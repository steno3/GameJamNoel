using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] public GameObject pauseMenu;

    private bool paused = false;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Update()
    {
        if (!paused && Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
            paused = true;
        }
        else if (paused && Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
            paused = false;
        }
    }
}
