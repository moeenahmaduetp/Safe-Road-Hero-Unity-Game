using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void ActiveScene()
    {
        Time.timeScale = 1f;
    }
    public void CloseScene()
    {
        Time.timeScale = 0f;
    }
    public void load_Scene(string S)
    {
        SceneManager.LoadScene(S);
    }
    public void Reset_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
