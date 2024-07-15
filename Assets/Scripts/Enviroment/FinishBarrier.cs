using Core;
using  Player;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace  Enviroment
{
    public class FinishBarrier : MonoBehaviour
    {
        [SerializeField] private GameObject _bricksEffectPrefab;
        public AudioClip BrickSound;
        public float BrickSoundVolume;
        private void OnTriggerEnter(Collider other)
        {
            PlayerModifire playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifire>();

            if (playerModifaer)
            {
                playerModifaer.HitBarrierHeigth();
                playerModifaer.HitBarrierWitdth();
                SoundManager.Instance.PlaySound(BrickSound,BrickSoundVolume);
                Destroy(gameObject);
                Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
            }
        }
    }

}
