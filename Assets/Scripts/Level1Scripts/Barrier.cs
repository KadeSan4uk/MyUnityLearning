using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifire playerModifaer =other.attachedRigidbody.GetComponent<PlayerModifire>();

        if (playerModifaer)
        {
            playerModifaer.HitBarrierHeigth();
            playerModifaer.HitBarrierWitdth();
            Destroy(gameObject);
        }
    }
}
