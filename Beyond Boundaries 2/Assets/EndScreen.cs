using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
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
