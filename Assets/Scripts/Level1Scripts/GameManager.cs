using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private GameObject _finishWindow;
    [SerializeField] private CoinManager _coinManager;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void PLay()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviuor>().Play();
    }

    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }

    public void NextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextLevel < SceneManager.sceneCountInBuildSettings)
        {
            _coinManager.SaveToProgress();

            SceneManager.LoadScene(nextLevel);
        }

    }
}
