using Player;
using Enviroment;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class FinishTrigger : MonoBehaviour
    {

        public AudioClip FinishAudioClip;
        public float FinishAudioClipVolume;

        private void OnTriggerEnter(Collider other)
        {
            PlayerBehaviuor playerBehaviuor = other.attachedRigidbody.GetComponent<PlayerBehaviuor>();

            if (playerBehaviuor)
            {
                SaveProgress();
                SoundManager.Instance.PlaySound(FinishAudioClip,FinishAudioClipVolume);
                playerBehaviuor.StartFinishBehaviuor();
                FindObjectOfType<GameManager>().ShowFinishWindow();
            }
        }
        public void SaveProgress()
        { // Получаем экземпляр CoinManager
            CoinManager coinManager = FindObjectOfType<CoinManager>();
            if (coinManager != null)
            {
                // Сохраняем значение NumberOfCoins в PlayerPrefs
                PlayerPrefs.SetInt("Coins", coinManager.NumberOfCoins);
                PlayerPrefs.Save(); // Принудительное сохранение на диск
            }
        }
    }



}
