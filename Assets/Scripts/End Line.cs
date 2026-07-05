using UnityEngine;

public class End_Line : MonoBehaviour
{
    public GameObject EndLine;
    public Rigidbody Player;

    private void OnTriggerStay(Collider collision)
    {
        Time.timeScale = 0f;
        EndLine.SetActive(true);
    }
}
