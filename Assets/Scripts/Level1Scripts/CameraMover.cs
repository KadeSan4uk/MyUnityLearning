using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _target;
    void Update()
    {
        transform.position = _target.position;
    }
}
