using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPointer : MonoBehaviour
{
    private GameObject Player;
    private float _originDistance;
    private Vector3 _originScale;
    private float _distance;
    private Vector3 _minScale;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _originDistance = Vector3.Distance(transform.position, Player.transform.position);
        _originScale = transform.localScale;
        _minScale = new Vector3(300, 300, 300);
    }

    private void Update()
    {
        _distance = Vector3.Distance(transform.position, Player.transform.position);
        transform.localScale = _originScale * _distance / _originDistance;
        if (transform.localScale.x < _minScale.x)
            transform.localScale = _minScale;
    }
}
