using System;
using UnityEditor;
using UnityEngine;

public class MainTurell : MonoBehaviour
{
    private ActionsTurell _actionsTurell;

	[SerializeField]
	private Transform _towerTurell;
	[SerializeField]
	private Transform _player;
	[SerializeField]
	private GameObject _bullet;

	private float _minDistance = 3;

	private void Awake()
	{
		_player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Start()
	{
		_actionsTurell = new ActionsTurell();
	}

	private RaycastHit _hit;
	private float _duration = 15;

	private void Update()
	{
		float distanceResult = 
			_actionsTurell.DistanceObject(_towerTurell, _player);
		
		if (distanceResult < _minDistance)
		{
			_actionsTurell.ObjectLookRotation(
				_towerTurell, _player);
		}
		_actionsTurell.TrigerOnPlayer(gameObject, _player, _hit, 
			_duration);
	}
}
