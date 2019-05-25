using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void gameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
