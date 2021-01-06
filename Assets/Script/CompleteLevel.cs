using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public void Completel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }

}
