using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrier : MonoBehaviour
{
    [SerializeField] private GameObject _bricksEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifire playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifire>();

        if (playerModifaer)
        {
            playerModifaer.HitBarrierHeigth();
            playerModifaer.HitBarrierWitdth();
            Destroy(gameObject);
            Instantiate(_bricksEffectPrefab,transform.position, transform.rotation);
        }
    }
}
