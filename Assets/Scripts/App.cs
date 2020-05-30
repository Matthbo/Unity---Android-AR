using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class App : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("Starting App");
        // NOOP
    }

    public string Message { get; set; }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
