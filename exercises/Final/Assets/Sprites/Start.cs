﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void MainMenuSwitcher()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1Switcher()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2Switcher()
    {
        SceneManager.LoadScene(2);
    }
}