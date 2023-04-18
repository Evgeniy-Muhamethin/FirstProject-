using UnityEngine;

public class Bullet : MonoBehaviour
{
	//TODO ������ ���������� ��������
	[SerializeField]
	private Transform _returnPosition;

	private ActionsTurell _actionsTurell;
	private HealthPlayer _healthPlayer;

	private float _distance;
	private float _maxDistance = 5;
	private int _damage = 5;

	private void Start()
	{
		_actionsTurell = new ActionsTurell();
	}

	private void Update()
	{
		gameObject.transform.Translate(Vector3.forward * 
			Time.deltaTime);

		_distance = _actionsTurell.DistanceObject(_returnPosition,
			gameObject.transform);

		if (_distance > _maxDistance)
		{
			ReturObjectPositions();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") | other.CompareTag("Walls")
			| other.CompareTag("Plane"))
		{
			ReturObjectPositions();
			_healthPlayer.Health -= _damage;
		}
	}

	//����� ���������� ������ � �������������� ������� 
	private void ReturObjectPositions()
	{
		gameObject.transform.position =
				_returnPosition.position;
	}
}
