using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace  Core
{
    public class Progress : MonoBehaviour
    {
        public int Coins;
        public int Width;
        public int Height;

        public static PlayerPrefs PlayerPrefs;        

        public static Progress Instance;


        private void Awake()
        {
            //проверка что обьект(компонент) будет в одном екземляре на сцене
            if (Instance == null)
            {
                transform.parent = null;// отвязка от родителей
                DontDestroyOnLoad(gameObject);// сохранение обьекта при переходе на следу.щий уровень
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

        }
        
    }

}
