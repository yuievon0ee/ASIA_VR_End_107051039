using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public void RestartGame()
    {
        SceneManager.LoadScene("VR場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
