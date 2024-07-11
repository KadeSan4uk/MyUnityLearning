using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MyLearning1.Assets.Scripts
{
    public class PreFinishTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            PlayerBehaviuor playerBehaviuor = other.attachedRigidbody.GetComponent<PlayerBehaviuor>();

            if (playerBehaviuor)
            {
                playerBehaviuor.StartPreFinishBehaviuor();
            }
        }
    }

}
