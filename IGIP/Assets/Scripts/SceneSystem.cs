using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public GameObject helpPanel;
    public void SceneChange(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void SetHelpPanel(bool b)
    {
        helpPanel.SetActive(b);
    }
}
