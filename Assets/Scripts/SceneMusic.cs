using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic: MonoBehaviour
{
    [SerializeField] private AudioClip[] AmbientMusic;

    private AudioSource _AudioSource;
    private int _numberClip;
    // Start is called before the first frame update
    void Awake()
    {
        _AudioSource = GetComponent<AudioSource>();
        _numberClip = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!_AudioSource.isPlaying)
        {
            _AudioSource.clip = AmbientMusic[_numberClip++ % AmbientMusic.Length];
            _AudioSource.Play();
        }
    }
}
