using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool PlayerDead = false;

    public float RestartDelay = 1f;
    public GameObject FinishUI;
    public GameObject FailUI;
    public void EndGame()
    {
        if(PlayerDead == false)
        {
            PlayerDead = true;
            Debug.Log("Gameover");
            FailUI.SetActive(true);
            Invoke("RestartGame", RestartDelay);
            

        }

        

    }
    
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void WinMessage()
    {
        FinishUI.SetActive(true);
        Debug.Log("Finished");

    }



}
