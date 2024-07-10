using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource _soundFinish;

    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviuor playerBehaviuor = other.attachedRigidbody.GetComponent<PlayerBehaviuor>();

        if (playerBehaviuor)
        {
            _soundFinish.Play();
            playerBehaviuor.StartFinishBehaviuor();
            FindObjectOfType<GameManager>().ShowFinishWindow();
        }
    }
}
