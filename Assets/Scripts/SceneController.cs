using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ButtonScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game!");
    }
}
