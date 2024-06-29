using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviuor : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;

    void Start()
    {
        _playerMove.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;

    }


}
