using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;
    public int ModificationPrice = 20;

    PlayerModifire _playerModifire;

    private void Start()
    {
        // один раз при старте находим компонент(обьект) и сохраняем к нему ссылку
        _playerModifire=FindObjectOfType<PlayerModifire>();
    }
    public void BuyWidth()
    {
        if (_coinManager.NumberOfCoins >= ModificationPrice)
        {
            _coinManager.SpendCoins(ModificationPrice);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Width += 25;
            _playerModifire.SetWidth(Progress.Instance.Width);
        }
    }
    public void BuyHeight()
    {
        if (_coinManager.NumberOfCoins >= ModificationPrice)
        {
            _coinManager.SpendCoins(ModificationPrice);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Height += 25;
            _playerModifire.SetHeight(Progress.Instance.Height);

        }
    }

}
