using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
   


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            
        }
    }
    void Restart()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            Destroy(GameObject.FindGameObjectWithTag("Music"));
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
              completeLevelUI.SetActive(true);

    }

}
