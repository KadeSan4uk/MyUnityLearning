using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    public void PLay()
    {
        _startMenu.SetActive(false);
    }
}
