using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("Day 1");
    }
}
