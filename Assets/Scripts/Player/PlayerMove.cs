using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace  Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] float _speed;
        [SerializeField] float _rotationSpeed = 100f;
        [SerializeField] Animator _animator;
        float minRotation = -70f;
        float maxRotation = 70f;

        void Update()
        // Time.deltaTime оптимизирует движение обьекта не зависимо от частоты кадров
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
                newPosition.x = Mathf.Clamp(newPosition.x, -2.6f, 2.6f);
                transform.position = newPosition;
                _animator.SetBool("Run", true);
            }
            else
            {
                _animator.SetBool("Run", false);
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

}

