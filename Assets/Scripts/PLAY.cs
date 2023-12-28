using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    public GameObject nonSettings;
    public GameObject creditsMenu;

    public AudioSource select;
    public void Start()
    {
        nonSettings.SetActive(true);
        creditsMenu.SetActive(false);
    }
    public void StartGame()
    {
        select.Play();
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        select.Play();
        nonSettings.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void exitCredits()
    {
        select.Play();
        nonSettings.SetActive(true);
        creditsMenu.SetActive(false);
    }
}
