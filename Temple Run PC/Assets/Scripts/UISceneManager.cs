using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum BuildIndex
{
    MainMenu,
    Game
}

public class UISceneManager : MonoBehaviour
{
    public static UISceneManager instance;
    [SerializeField] GameObject endGameScreen;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void ShowUI()
    {
        endGameScreen.SetActive(true);
    }

    public void NewGame()
    {
        SceneManager.LoadScene((int)BuildIndex.Game, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene((int)BuildIndex.MainMenu);
    }

}
