using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviuor : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PreFinishBehaviuor _preFinishBehaviuor;
    [SerializeField] Animator _animator;

    void Start()
    {
        _playerMove.enabled = false;
        _preFinishBehaviuor.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;
    }

    public void StartPreFinishBehaviuor()
    {
        _playerMove.enabled = false;
        _preFinishBehaviuor.enabled = true;
    }

    public void StartFinishBehaviuor()
    {
        _preFinishBehaviuor.enabled = false;
        _animator.SetTrigger("Dance");
    }


}
