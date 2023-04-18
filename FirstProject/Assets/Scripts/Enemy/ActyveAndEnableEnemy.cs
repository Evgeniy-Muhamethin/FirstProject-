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

	private void Update()
	{
		NavMeshEnemy(_agent, _player);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			gameObject.SetActive(false);
			_healthPlayer.Health--; //Наносим урон игроку 

			print($"{_healthPlayer.Health}");
		}
	}

	public void NavMeshEnemy(NavMeshAgent navMeshAgent, Transform player)
	{
		navMeshAgent.SetDestination(player.transform.position);
	}
}
