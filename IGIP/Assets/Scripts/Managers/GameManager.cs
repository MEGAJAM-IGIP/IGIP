using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SceneSystem sceneSystem;
    public static GameManager instance;

    public bool isGameOver;
    public int score;
    public float startTime;
    public float curTime;
    
    public Text timeText;
    public Text scoreText;
    public Text endScoreText;

    public GameObject timeOutPanel;
    public AudioClip endClip;
    
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    void Start()
    {
        score = 0;
        curTime = startTime;
        isGameOver = false;
        
        curTime = startTime;
        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + curTime;
    }
    
    void Update()
    {
        if (curTime > 0)
        {
            curTime -= Time.deltaTime;
        }
        else if(isGameOver == false)
        {
            curTime = 0f;
            isGameOver = true;
            endScoreText.text = "Score: " + score;
            sceneSystem.SetPanel(timeOutPanel);
            AudioSystem.instance.PlaySound(endClip);
        }
        timeText.text = "Time: " + Mathf.Round(curTime);
    }

    public void GetScore(int addScore)
    {
        if (isGameOver) return;
        score += addScore;
        scoreText.text = "Score: " + score;
    }
}
