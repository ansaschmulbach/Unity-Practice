﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LoadMainMenu()
    {
        GameManager.instance.LoadLevel1();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}