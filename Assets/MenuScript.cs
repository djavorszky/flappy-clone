using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}