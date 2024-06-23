using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _target;

    void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = _target.position;
        }
    }
}
