using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    void Update()
    {
        ScoreText.text = Player.position.z.ToString("0"); 



    }
}
