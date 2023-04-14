using System;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public MovePlayer movePlayer;

	[SerializeField]
	private Rigidbody _rigidbody;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private float _seedRotations;

	//Health player
	private int _health = 100;
	private HealthPlayer _healthPlayer;
	//-----------------------------------

	private KeyCode[] _keyCode;

	private void Start()
	{
		movePlayer = new MovePlayer();

		_keyCode = new KeyCode[4] 
		{KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D};

		_healthPlayer.Health = _health;
	}


	private void Update()
	{
		movePlayer.MovePlayerMethod(
			_rigidbody, _speed, _seedRotations, 
			_keyCode[0], _keyCode[1],
			_keyCode[2], _keyCode[3]);

		if (Input.GetKey(KeyCode.Tab))
		{
			_healthPlayer.Health--;
		}
	}
}
