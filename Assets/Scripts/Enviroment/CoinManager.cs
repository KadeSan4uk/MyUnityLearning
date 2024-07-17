using TMPro;
using  Core;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace  Enviroment
{
    public class CoinManager : MonoBehaviour
    {
        public int NumberOfCoins;
        [SerializeField] TextMeshProUGUI _text;

        private void Start()
        {
            //обрвщение к статическому полю класса.
           // NumberOfCoins = Progress.Instance.Coins;
           // Получаем экземпляр CoinManager
           CoinManager coinManager = FindObjectOfType<CoinManager>();
            NumberOfCoins = PlayerPrefs.GetInt("Coins", coinManager.NumberOfCoins);
            _text.text = NumberOfCoins.ToString();
        }

        public void AddOne()
        {
            NumberOfCoins++;
            _text.text = NumberOfCoins.ToString();
        }

        public void SaveToProgress()
        {
            //Progress.Instance.Coins = NumberOfCoins;
            PlayerPrefs.SetInt("Coins", NumberOfCoins); // Сохранение в PlayerPrefs
            PlayerPrefs.Save(); // Принудительное сохранение на диск
        }

        public void SpendCoins(int value)
        {
            NumberOfCoins -= value;
            _text.text = NumberOfCoins.ToString();
        }

    }

}