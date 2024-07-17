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
        [SerializeField] private float FinishAudioClipVolume;

        private void OnTriggerEnter(Collider other)
        {
            PlayerBehaviuor playerBehaviuor = other.attachedRigidbody.GetComponent<PlayerBehaviuor>();

            if (playerBehaviuor)
            {
                SaveProgress();
                SoundManager.Instance.PlaySound(FinishAudioClip, FinishAudioClipVolume);
                playerBehaviuor.StartFinishBehaviuor();
                FindObjectOfType<GameManager>().ShowFinishWindow();
            }
        }
        public void SaveProgress()
        {
            PlayerModifire playerModifier = FindObjectOfType<PlayerModifire>();
            if (playerModifier != null)
            {
                // Сохраняем значения в Progress
                Progress.Instance.Height = playerModifier.Height();
                Progress.Instance.Width = playerModifier.Width();
            }
            // Получаем экземпляр CoinManager
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
