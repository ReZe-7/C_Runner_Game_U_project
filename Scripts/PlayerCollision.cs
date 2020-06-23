using UnityEditor;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    private void OnCollisionEnter(Collision PlayerCollisionInfo)
    {
        if(PlayerCollisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }



}
