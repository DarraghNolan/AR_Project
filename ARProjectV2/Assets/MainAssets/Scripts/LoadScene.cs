using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public int SceneINT;

    public void SwitchScenes()
    {
        SceneManager.LoadScene(SceneINT);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
