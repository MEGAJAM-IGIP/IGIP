using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    private static SceneSystem instance;

    public static SceneSystem Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<SceneSystem>();

                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newObj = new GameObject().AddComponent<SceneSystem>();
                    instance = newObj;
                    newObj.name = "SceneSystem";
                }
            }

            return instance;
        }
    }

    public bool isGameOver;
    
    private void Awake()
    {
        var objs = FindObjectsOfType<SceneSystem>();
        if (objs.Length != 1)
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
    }
    
    public void SceneChange(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void SetPanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}
