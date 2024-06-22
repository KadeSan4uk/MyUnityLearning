using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestFilds : MonoBehaviour
{
    // для отображения полей в инспекторе Юнити
    [SerializeField] private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;
    [SerializeField] private Color _bodyColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isAlive;
    [SerializeField] private Light _sun;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _ball;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, _height, 1);
        gameObject.name = _name;
        gameObject.GetComponent<Renderer>().material.color = _bodyColor;
        transform.position = _startPosition;
        gameObject.SetActive(_isAlive);

        _sun.intensity = 2;
        _sun.color = Color.yellow;
        //_sun.color = _bodyColor;

        _camera.fieldOfView = 60;

    }

    // Update is called once per frame
    void Update()
    {
        _camera.transform.position = transform.position + new Vector3(0.001f, 3.574f, -10);
        _ball.position = transform.position + new Vector3(0, 2, 0);
    }
}
