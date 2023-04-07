using UnityEngine;
using UnityEngine.AI;

public class ActyveAndEnableEnemy : MonoBehaviour
{
	[SerializeField]
	private Transform _player;
	[SerializeField]
	private NavMeshAgent _agent;

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
			print("Object was connected");
		}
	}

	public void NavMeshEnemy(NavMeshAgent navMeshAgent, Transform player)
	{
		navMeshAgent.SetDestination(player.transform.position);
	}
}
