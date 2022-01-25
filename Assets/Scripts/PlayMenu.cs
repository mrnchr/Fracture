using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityEngine.SceneManagement; 

public class PlayMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject Menu;
    private bool isActiveMenu;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        isActiveMenu = false;
        Menu.SetActive(false);
    }

    public void ContinueBtn()
    {
        SetMenu();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetMenu();
        }
    }

    private void SetMenu()
    {
        isActiveMenu = !isActiveMenu;
        Menu.SetActive(isActiveMenu);
        Player.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = !isActiveMenu;
    }
}
