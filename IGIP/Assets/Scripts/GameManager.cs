using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameOver;
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("instance is not null");
            return;
        }

        instance = this;
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
