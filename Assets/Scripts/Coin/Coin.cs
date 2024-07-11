using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MyLearning1.Assets
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private GameObject _coinsEffectCollect;
        [SerializeField] private float _rotationSpeed;
        void Update()
        {
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<CoinManager>().AddOne();
            Destroy(gameObject);
            Instantiate(_coinsEffectCollect, transform.position, transform.rotation);
        }
    }

}
