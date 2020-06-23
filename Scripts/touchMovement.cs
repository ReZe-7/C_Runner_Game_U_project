using UnityEngine;
using UnityEngine.UI;

public class touchMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float playerMovementEffort = 500f;
    
    public void onPress()
    {
        rb.AddForce(playerMovementEffort * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }



}
