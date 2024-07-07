using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrier : MonoBehaviour
{
    [SerializeField] private AudioSource _breakWall;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifire playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifire>();

        if (playerModifaer)
        {
            _breakWall.Play();
            playerModifaer.HitBarrierHeigth();
            playerModifaer.HitBarrierWitdth();
            Destroy(gameObject);
        }
    }
}
