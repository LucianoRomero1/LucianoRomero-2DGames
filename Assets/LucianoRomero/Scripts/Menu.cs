using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoToGame1(){
        SceneManager.LoadScene("CollectItems");
    }

    public void GoToGame2(){
        SceneManager.LoadScene("Runner");
    }
}
