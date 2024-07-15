using UnityEngine;
using UnityEngine.UIElements;

namespace CameraView
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] Transform _target;

        private void Start()
        {
            CameraFree();
        }

        void LateUpdate()
        {
            CameraSetTarget();
        }
        private void CameraFree()
        {
            //отвязка камеры от Плеера как дочерняя при старте
            transform.parent = null;
        }
        private void CameraSetTarget()
        {
            if (_target)
                transform.position = _target.position;
        }
    }
}
