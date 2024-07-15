using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance; // Синглтон для удобного доступа к SoundManager

        private AudioSource audioSource;
        public AudioClip _backgroundMusic;
        public float BackgroundMusicVolume;

        void Awake()
        {
            // Синглтон, чтобы обеспечить один экземпляр SoundManager
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                audioSource = GetComponent<AudioSource>();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        void Start()
        {
            // Настройка фоновой музыки
            audioSource.clip = _backgroundMusic; // Назначаем клип
            audioSource.loop = true; // Включаем повтор
            audioSource.Play(); // Запускаем воспроизведение
        }

        public void PlaySound(AudioClip clip, float volume)
        {
            if (clip != null)
            {
                audioSource.PlayOneShot(clip,volume);
            }
        }
    }
}
