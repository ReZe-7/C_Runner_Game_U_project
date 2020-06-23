using UnityEngine;

public class WinMessage : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.WinMessage();
        FindObjectOfType<PlayerMovement>().enabled = false;

    }

}
