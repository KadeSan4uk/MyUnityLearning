using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int _numberOfCoinsInLevel;
    [SerializeField] TextMeshProUGUI _text;

    public void AddOne()
    {
        _numberOfCoinsInLevel++;
        _text.text = _numberOfCoinsInLevel.ToString();
    }

}
