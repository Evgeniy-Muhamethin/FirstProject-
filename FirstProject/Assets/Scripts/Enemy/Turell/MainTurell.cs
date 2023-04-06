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
	[SerializeField]
	private GameObject _bullet;

	private float _minDistance = 3;

	private void Start()
	{
		actionsTurell = new ActionsTurell();
	}

	private void Update()
	{
		float distanceResult = 
			actionsTurell.DistanceObject(_towerTurell, _player);
		
		if (distanceResult < _minDistance)
		{
			actionsTurell.ObjectLookRotation(
				_towerTurell, _player);
			Debug.DrawLine(_towerTurell.position, _player.position,
				Color.blue);

		}
	}
}
