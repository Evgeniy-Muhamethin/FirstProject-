using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    private int speedFly = 8;

    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * 
            speedFly * Time.deltaTime);
    }
}
