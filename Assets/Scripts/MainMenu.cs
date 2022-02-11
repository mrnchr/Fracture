using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip Click;

    public void PlayBtn()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("House");
    }

    public void ExitBtn()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
