using Core;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Enviroment
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private GameObject _coinsEffectCollect;
        [SerializeField] private float _rotationSpeed;
        public AudioClip CoinsAudioClip;
        [SerializeField] private float CoinsAudioClipVolume;
        void Update()
        {
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<CoinManager>().AddOne();
            SoundManager.Instance.PlaySound(CoinsAudioClip, CoinsAudioClipVolume);
            Destroy(gameObject);
            Instantiate(_coinsEffectCollect, transform.position, transform.rotation);
        }
    }

}
