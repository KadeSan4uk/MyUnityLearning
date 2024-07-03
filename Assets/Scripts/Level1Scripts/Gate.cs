using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;

    private void OnValidate()
    {
        _gateAppearaence.UpdateVisual(_deformationType, _value);
    }

    private void OnTriggerEnter(Collider other)
    {
        //убеждаемся что тот компонент который вызвал тригер и есть Player RigiBody
        PlayerModifaer playervodifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playervodifaer)
        {
            if (_deformationType == DeformationType.Width)
            {
                playervodifaer.AddWidth(_value);
            }
            else if (_deformationType == DeformationType.Height)
            {
                playervodifaer.AddHeight(_value);
            }

            Destroy(gameObject);
        }
    }
}
