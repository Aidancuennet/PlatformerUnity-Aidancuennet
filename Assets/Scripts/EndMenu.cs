﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
