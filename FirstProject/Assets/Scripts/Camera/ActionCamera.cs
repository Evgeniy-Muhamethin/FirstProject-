using System;
using UnityEngine;

public class ActionCamera 
{
    public void Transform(Transform cameraTransform, 
        Transform playerTransform)
    {
        //TODO Установить смещение камеры в сторону движения игрока 
        cameraTransform.transform.position = new Vector3(0,7,1);
	}
}
