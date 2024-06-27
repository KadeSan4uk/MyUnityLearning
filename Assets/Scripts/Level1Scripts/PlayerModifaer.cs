using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerModifaer : MonoBehaviour
{

    [SerializeField] int _width;
    [SerializeField] int _height;
    float _widthMultiplayer = 0.005f;
    float _heightMultiplayer = 0.001f;

    [SerializeField] Renderer _renderer;
    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _collaiderTransform;


    void Update()
    {  
        _collaiderTransform.localScale = new Vector3(1,1.84f+ _height * _heightMultiplayer,1);

        if (Input.GetKeyDown(KeyCode.T))
        {
            AddWidth(20);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            AddHeight(20);
        }
    }

    public void AddWidth(int value)
    {
        _width += value;
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);
    }

    public void AddHeight(int value)
    { //Значение 0.17F значит стандартное расстояние между костями спины модели 
        float offsetY = _height * _heightMultiplayer + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _height += value;
        _width += value;
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);

        //_renderer.material.SetFloat("_PushValue", _height * _heightMultiplayer);

    }
}
