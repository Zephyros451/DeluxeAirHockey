﻿using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<SceneManager>();
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(this);
        }
    }

    public void LoadMainMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadResultScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
