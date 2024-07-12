using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MyLearning1.Assets.Scripts.Player;

namespace MyLearning1.Assets.Scripts.Enviroment
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
