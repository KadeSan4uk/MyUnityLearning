using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviuor playerBehaviuor = other.attachedRigidbody.GetComponent<PlayerBehaviuor>();

        if (playerBehaviuor)
        {
            playerBehaviuor.StartFinishBehaviuor();
        }
    }
}
