using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int _numberOfCoinsInLevel;

    public void AddOne()
    {
        _numberOfCoinsInLevel++;
    }

}
