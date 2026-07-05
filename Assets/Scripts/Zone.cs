using UnityEngine;

public class Zone : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Rigidbody Player;

    private void OnTriggerStay(Collider collision)
    {
        float speed = Player.velocity.magnitude * 3.6f;
        
        if (speed > 60)
        {
            Time.timeScale = 0f;
            gameOverCanvas.SetActive(true);
        }

    }
}
   
