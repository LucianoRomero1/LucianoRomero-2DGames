using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoToGame1()
    {
        SceneManager.LoadScene("CollectItems");
    }

    public void GoToGame2()
    {
        SceneManager.LoadScene("Runner");
    }

    public void GoToPiano()
    {
        SceneManager.LoadScene("Piano");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
