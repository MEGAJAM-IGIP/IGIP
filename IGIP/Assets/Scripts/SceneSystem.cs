using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    private void Awake()
    {
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
