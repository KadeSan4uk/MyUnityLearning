using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MyLearning1.Assets
{
    public class CoinManager : MonoBehaviour
    {
        public int NumberOfCoins;
        [SerializeField] TextMeshProUGUI _text;

        private void Start()
        {
            //обрвщение к статическому полю класса.
            NumberOfCoins = Progress.Instance.Coins;
            _text.text = NumberOfCoins.ToString();
        }

        public void AddOne()
        {
            NumberOfCoins++;
            _text.text = NumberOfCoins.ToString();
        }

        public void SaveToProgress()
        {
            Progress.Instance.Coins = NumberOfCoins;
        }

        public void SpendCoins(int value)
        {
            NumberOfCoins -= value;
            _text.text = NumberOfCoins.ToString();
        }

    }

}
