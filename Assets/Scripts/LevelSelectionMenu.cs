using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenu : MonoBehaviour
{
    [SerializeField] private GameObject LevelLayout;
    [SerializeField] private GameObject MenuLayout;

    public void LevelButton(string sceneName)
    {
        GetComponent<AudioSource>().Play();
        if (SceneManager.GetActiveScene().name != sceneName)
            SceneManager.LoadScene(sceneName);
    }

    public void ToggleLevelMenu()
    {
        GetComponent<AudioSource>().Play();
        LevelLayout.SetActive(!LevelLayout.activeSelf);
        MenuLayout.SetActive(!MenuLayout.activeSelf);
    }

    private void Awake()
    {
        LevelLayout.SetActive(false);
        MenuLayout.SetActive(true);
    }
}
