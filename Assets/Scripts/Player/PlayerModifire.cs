using Core;
using Enviroment;
using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace Player
{
    public class PlayerModifire : MonoBehaviour
    {

        [SerializeField] int _width;
        [SerializeField] int _height;
        float _widthMultiplayer = 0.0005f;
        float _heightMultiplayer = 0.008f;

        [SerializeField] Renderer _renderer;
        [SerializeField] Transform _topSpine;
        [SerializeField] Transform _bottomSpine;

        [SerializeField] Transform _collaiderTransform;
        public AudioClip modificationSound;
        [SerializeField] private float ModificationSoundVolume;

        private void Start()
        {
            SetWidth(Progress.Instance.Width);
            SetHeight(Progress.Instance.Height);
        }

        void Update()
        {
            //Значение 0.17F значит стандартное расстояние между костями спины модели 
            float offsetY = _height * _heightMultiplayer + 0.17f;

            _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);

            _collaiderTransform.localScale = new Vector3(0.7f + _width * _widthMultiplayer*2.5f, 1.84f + _height * _heightMultiplayer, 0.7f + _width * _widthMultiplayer*2.5f);
        }


        public void AddWidth(int value)
        {
            _width += value;
            UpdateWidth();
            if (value > 0)
            {
                PlayModificationSound();
            }
        }

        public void AddHeight(int value)
        {
            _height += value;
            if (value > 0)
            {
                PlayModificationSound();
            }
        }

        public void SetWidth(int value)
        {
            _width += value;
            UpdateWidth();

        }
        public void SetHeight(int value)
        {
            _height += value;
        }

        public void HitBarrierWitdth()
        {
            if (_width > 0)
            {
                _width -= 3;
                UpdateWidth();
            }
            else
            {
                Die();
            }
        }
        public void HitBarrierHeigth()
        {
            if (_height > 0)
            {
                _height -= 4;
            }
            else
            {
                Die();
            }

        }
        private void PlayModificationSound()
        {
            SoundManager.Instance.PlaySound(modificationSound, ModificationSoundVolume);

        }

        void UpdateWidth()
        {
            _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);
        }

        void Die()
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().ShowFinishWindow();
        }

        public int Height()
        {
            return _height;
        }
        public int Width()
        {
            return _width;
        }
    }

}
