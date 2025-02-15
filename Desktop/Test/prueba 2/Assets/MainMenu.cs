
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SelectBasketColor(Color color)
    {
        PlayerPrefs.SetString("BasketColor", ColorUtility.ToHtmlStringRGB(color));
    }
}