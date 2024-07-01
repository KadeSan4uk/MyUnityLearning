using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void PLay()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviuor>().Play();
    }
}
