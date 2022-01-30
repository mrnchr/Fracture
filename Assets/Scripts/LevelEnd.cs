using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Win Win;

    private int _nextScene;

    private void OnTriggerEnter(Collider other)
    {
        _nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (other.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Altar")
                Win.ActiveWin();
            else
                SceneManager.LoadScene(_nextScene);
        }
    }
}
