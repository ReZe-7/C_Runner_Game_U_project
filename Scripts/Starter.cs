using UnityEngine;
using UnityEngine.SceneManagement;


public class Starter : MonoBehaviour
{

    public void GameStarter()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
