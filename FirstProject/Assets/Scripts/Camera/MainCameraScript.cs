using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _cameraTransform;
	[SerializeField]
	private Transform _playerTransform;

    private ActionCamera _actionCamera;

    private Vector3 _offset;

	void Start()
    {
        _actionCamera = new ActionCamera();

        //_cameraTransform =
        //    GameObject.FindGameObjectWithTag("MainCamera").transform;
        _playerTransform = 
            GameObject.FindGameObjectWithTag("Player").transform;

        _offset = transform.position;//test
    }

    void Update()
    {
        //_actionCamera.Transform(_cameraTransform, _playerTransform);
        transform.position = _playerTransform.position + _offset;//test
    }
}
