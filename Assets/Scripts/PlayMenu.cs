using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityEngine.SceneManagement; 

public class PlayMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject Menu;
    public GameObject GameMenu;
    public bool IsCan;

    private bool isActiveMenu;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        isActiveMenu = false;
        Menu.SetActive(false);
        GameMenu.SetActive(true);
        IsCan = true;
    }

    public void ContinueBtn()
    {
        GetComponent<AudioSource>().Play();
        SetMenu();
    }

    public void MainMenuButton()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsCan)
        {
            SetMenu();
        }
    }

    private void SetMenu()
    {
        isActiveMenu = !isActiveMenu;
        Menu.SetActive(isActiveMenu);
        GameMenu.SetActive(!isActiveMenu);
        Player.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = !isActiveMenu;
    }
}
