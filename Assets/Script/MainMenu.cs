﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit The Game ! ");
        Application.Quit();
    }
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
