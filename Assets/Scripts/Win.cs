using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject WinMenu;
    [SerializeField] private GameObject GameMenu;
    [SerializeField] private PlayMenu PlayMenu;

    private void Awake()
    {
        WinMenu.SetActive(false);
        GameMenu.SetActive(true);
    }

    public void ActiveWin()
    {
        PlayMenu.IsCan = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        GameMenu.SetActive(false);
        WinMenu.SetActive(true);
    }
}
