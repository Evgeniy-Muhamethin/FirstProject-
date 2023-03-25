using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public MovePlayer movePlayer;

	[SerializeField]
	private Rigidbody _rigidbody;
	[SerializeField]
	private float _speed;

	private KeyCode[] _keyCode;

	private void Start()
	{
		movePlayer = new MovePlayer();

		_keyCode = new KeyCode[4] 
		{KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D};
	}


	private void Update()
	{
		movePlayer.MovePlayerMethod(
			_rigidbody, _speed, _keyCode[0], _keyCode[1],
			_keyCode[2], _keyCode[3]);
	}
}
