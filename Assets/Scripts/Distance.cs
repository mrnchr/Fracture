using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject Aim;

    private float _distance;
    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        _distance = Vector3.Distance(_player.transform.position, Aim.transform.position);

        GetComponent<Text>().text = Mathf.Round(_distance).ToString() + " M";
    }


}
