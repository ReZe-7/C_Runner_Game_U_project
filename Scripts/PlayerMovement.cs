using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public string rightMovementKey;
    public string leftMovementKey;
    public string reverseMovementKey;
    public float playerMovementEffort = 500f;
    public float reverseForce = 800f;
    // Update is called once per frame
    public float DeathHeight = -1f;
    
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey(rightMovementKey))
        {
            rb.AddForce(playerMovementEffort * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(leftMovementKey))
        {
            rb.AddForce(-playerMovementEffort * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(reverseMovementKey))
        {
            rb.AddForce(0, 0, -reverseForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(rb.position.y <= DeathHeight)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    public void leftMovement()
    {
        rb.AddForce(-playerMovementEffort * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
