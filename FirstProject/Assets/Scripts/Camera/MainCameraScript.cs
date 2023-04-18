using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _cameraTransform;
	[SerializeField]
	private Transform _playerTransform;

    private ActionCamera _actionCamera;

	void Start()
    {
        _actionCamera = new ActionCamera();

        _cameraTransform =
            GameObject.FindGameObjectWithTag("MainCamera").transform;
        _playerTransform = 
            GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        _actionCamera.Transform(_cameraTransform, _playerTransform);
    }
}
