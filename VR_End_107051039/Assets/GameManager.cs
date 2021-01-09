using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "布偶") 
        {
            print("一號燈爆掉");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("VR場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
