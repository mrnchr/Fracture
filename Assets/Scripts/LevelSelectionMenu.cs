using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenu : MonoBehaviour
{
    public GameObject LevelLayout;
    public GameObject MenuLayout;

    public void LevelButton(string sceneName)
    {
        if(SceneManager.GetActiveScene().name != sceneName)
            SceneManager.LoadScene(sceneName);
    }

    public void ToggleLevelMenu()
    {
        LevelLayout.SetActive(!LevelLayout.activeSelf);
        MenuLayout.SetActive(!MenuLayout.activeSelf);
    }

    private void Awake()
    {
        LevelLayout.SetActive(false);
        MenuLayout.SetActive(true);
    }
}
