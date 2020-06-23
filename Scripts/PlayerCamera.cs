using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;


    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + offset;
    }
}
