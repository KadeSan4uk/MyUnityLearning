using UnityEngine;
using UnityEngine.UIElements;

namespace MyLearning1.Assets.Scripts
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] Transform _target;

        private void Start()
        {
            //отвязка камеры от Плеера как дочерняя при старте
            transform.parent = null;
        }

        void LateUpdate()
        {
            if (_target)
            {
                transform.position = _target.position;
            }
        }
    }
}
