using System;
using UnityEngine;

public class ActionCamera 
{
    public void Transform(Transform cameraTransform, 
        Transform playerTransform)
    {
        //TODO ���������� �������� ������ � ������� �������� ������ 
        cameraTransform.transform.position = new Vector3(0,7,1);
	}
}
