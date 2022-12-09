using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingUIScreens : MonoBehaviour
{
    [SerializeField] GameObject[] OldUIElements;
    [SerializeField] GameObject[] NewUIElements;

    public void OpenNewUIScreen()
    {
        foreach (GameObject UIElement in OldUIElements)
        {
            UIElement.gameObject.SetActive(false);
        }
        foreach (GameObject UIElement in NewUIElements)
        {
            UIElement.gameObject.SetActive(true);
        }
    }

    public void BackToOldUIScreen()
    {
        foreach (GameObject UIElement in NewUIElements)
        {
            UIElement.gameObject.SetActive(false);
        }
        foreach (GameObject UIElement in OldUIElements)
        {
            UIElement.gameObject.SetActive(true);
        }
    }
}
