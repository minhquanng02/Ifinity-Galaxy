using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    } 

    public void LoadSingleGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMultiGame()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
