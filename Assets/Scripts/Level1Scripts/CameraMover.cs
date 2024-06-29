using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _target;

    void LateUpdate()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
    }
}
