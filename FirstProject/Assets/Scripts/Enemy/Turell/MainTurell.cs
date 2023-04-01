using System;
using UnityEditor;
using UnityEngine;

public class MainTurell : MonoBehaviour
{
    private ActionsTurell actionsTurell;

	[SerializeField]
	private Transform _towerTurell;
	[SerializeField]
	private Transform _player;

	private void Start()
	{
		actionsTurell = new ActionsTurell();
	}

	private void Update()
	{
		actionsTurell.ObjectLookRotation(
			_towerTurell, _player);
		Debug.DrawLine(_towerTurell.position, _player.position,
			Color.blue);
	}
}
