using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaer playerModifaer =other.attachedRigidbody.GetComponent<PlayerModifaer>();

        if (playerModifaer)
        {
            playerModifaer.HitBarrierHeigth();
            playerModifaer.HitBarrierWitdth();
            Destroy(gameObject);
        }
    }
}
