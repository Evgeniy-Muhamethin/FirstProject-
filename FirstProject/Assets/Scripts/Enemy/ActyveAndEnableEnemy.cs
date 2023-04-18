using UnityEngine;
using UnityEngine.AI;

public class ActyveAndEnableEnemy : MonoBehaviour
{
	[SerializeField]
	private Transform _player;
	[SerializeField]
	private NavMeshAgent _agent;

	HealthPlayer _healthPlayer;

	private void Awake()
	{
		_player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	//RaycastHit ����� ��������� �������� � ����� �������������.
	//��������� ����������� ��� ����������.
	RaycastHit hit;
	private void Update()
	{
		NavMeshEnemy(_agent, _player);

		//TODO ������� � ��������� ����� 
		#region Phusics Raycast and RaycastHit �������� ������������ ������ 
		var directions = _player.position - gameObject.transform.position; //��� ���������� ������ �������� ���������� �� ��������� ����� �� �������� �����
		var startPosition = gameObject.transform.position;
		var resultPhysics = Physics.Raycast(startPosition, directions, out hit, 15);

		Color color = Color.red;
		if (resultPhysics)
		{
			if (hit.collider.gameObject.CompareTag("Player"))
			{
				color = Color.green;
			}
		}
		Debug.DrawRay(startPosition, directions, color);
		#endregion
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			gameObject.SetActive(false);
			_healthPlayer.Health--;
		}
	}

	public void NavMeshEnemy(NavMeshAgent navMeshAgent, Transform player)
	{
		navMeshAgent.SetDestination(player.transform.position);
	}
}
