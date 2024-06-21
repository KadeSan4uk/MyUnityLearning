using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoxMoover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,2,0);// передвинуть по позиции
        transform.eulerAngles = new Vector3(0,45,30);// вращать обьект в пространстве (в градцсах)
        transform.localScale = new Vector3(2,2,3);// масштабировать обьект 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
