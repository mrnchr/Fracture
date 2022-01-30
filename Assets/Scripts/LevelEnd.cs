using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    private int _nextScene;
    private void OnTriggerEnter(Collider other)
    {
        _nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (other.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Altar")
                ActiveWin();
            else
                SceneManager.LoadScene(_nextScene);
        }
    }

    private void ActiveWin()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        //TODO: enable WinMenu

    }
}
