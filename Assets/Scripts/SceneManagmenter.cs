using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagmenter : MonoBehaviour
{
    public void ClassicGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HardGame()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
