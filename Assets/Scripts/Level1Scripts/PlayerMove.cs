using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed = 100f;
    private float minRotation = -70f;
    private float maxRotation = 70f;  

    void Update()
    // Time.deltaTime оптимизирует движение обьекта не зависимо от частоты кадров
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.9f, 2.9f);
            transform.position = newPosition;

        }

        float currentYRotation = transform.localEulerAngles.y;

        // Преобразуем угол в диапазон от -180 до 180 градусов
        if (currentYRotation > 180)
        {
            currentYRotation -= 360;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            currentYRotation -= _rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            currentYRotation += _rotationSpeed * Time.deltaTime;
        }

        // Ограничиваем угол поворота
        currentYRotation = Mathf.Clamp(currentYRotation, minRotation, maxRotation);

        // Устанавливаем новый угол поворота
        transform.localRotation = Quaternion.Euler(0, currentYRotation, 0);
    }
}
