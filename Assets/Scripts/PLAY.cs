using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject nonSettings;
    public GameObject creditsMenu;
    public void Start()
    {
        nonSettings.SetActive(true);
        settingsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        nonSettings.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void exitSettings()
    {
        nonSettings.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void Credits()
    {
        nonSettings.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void exitCredits()
    {
        nonSettings.SetActive(true);
        creditsMenu.SetActive(false);
    }
}
