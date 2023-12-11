using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Canvas pauseMenu;

    private void Start()
    {
        pauseMenu.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenu.enabled = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.enabled = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void Resume()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
