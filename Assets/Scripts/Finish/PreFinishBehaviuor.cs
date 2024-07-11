using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MyLearning1.Assets
{
    public class PreFinishBehaviuor : MonoBehaviour
    {
        void Update()
        {
            //Позиция Х постепенно меняеться от текущего значения до 0
            float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * 2f);
            float y = transform.position.z + 3f * Time.deltaTime;
            transform.position = new Vector3(x, 0, y);

            // Поворот по Y постепенно меняеться  от текущего значения до 0
            float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
            transform.eulerAngles = new Vector3(0, rot, 0);
        }
    }

}
