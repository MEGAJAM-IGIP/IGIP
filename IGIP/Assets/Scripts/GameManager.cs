using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<GameManager>();

                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newObj = new GameObject().AddComponent<GameManager>();
                    instance = newObj;
                    newObj.name = "GameManager";
                }
            }

            return instance;
        }
    }

    public bool isGameOver;
    
    public int score;
    public float startTime;
    public float curTime;
    
    public Text timeText;
    public Text scoreText;
    
    private void Awake()
    {
        var objs = FindObjectsOfType<GameManager>();
        if (objs.Length != 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        timeText = GetComponent<Text>();
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + startTime;
    }
    
    void Update()
    {
        if (curTime > 0)
        {
            curTime -= Time.deltaTime;
        }
        else
        {
            curTime = 0f;
            isGameOver = true;
        }
        timeText.text = "Time: " + Mathf.Round(curTime);
    }

    public void GetScore(int addScore)
    {
        score += addScore;
        scoreText.text = "Score: " + score;
    }
}
