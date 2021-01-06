using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit The Game");
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);

    }
}
