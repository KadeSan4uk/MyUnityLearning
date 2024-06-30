using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerModifaer : MonoBehaviour
{

    [SerializeField] int _width;
    [SerializeField] int _height;
    float _widthMultiplayer = 0.0005f;
    float _heightMultiplayer = 0.01f;

    [SerializeField] Renderer _renderer;
    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _collaiderTransform;


    void Update()
    {
        //Значение 0.17F значит стандартное расстояние между костями спины модели 
        float offsetY = _height * _heightMultiplayer + 0.17f;

        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);

        _collaiderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplayer, 1);
    }


    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }

    public void AddHeight(int value)
    {
        _height += value;
    }

    public void HitBarrierWitdth()
    {
        if (_width > 0)
        {
            _width -= 30;
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
            _height -= 50;
        }
        else
        {
            Die();
        }

    }

    void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
