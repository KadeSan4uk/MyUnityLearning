using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using  Player;

namespace  Enviroment
{
    public class FinishBarrier : MonoBehaviour
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
                Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
            }
        }
    }

}
