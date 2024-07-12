using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using MyLearning1.Assets.Scripts.Player;
using MyLearning1.Assets.Scripts.Enviroment;

namespace MyLearning1.Assets.Scripts.Core
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject _startMenu;
        [SerializeField] TextMeshProUGUI _levelText;
        [SerializeField] GameObject _finishWindow;
        [SerializeField] CoinManager _coinManager;

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

}
