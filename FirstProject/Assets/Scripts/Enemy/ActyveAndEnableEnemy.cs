using UnityEngine;
using UnityEngine.AI;

public class ActyveAndEnableEnemy : MonoBehaviour
{
	[SerializeField]
	private Transform _player;
	[SerializeField]
	private NavMeshAgent _agent;

	private HealthPlayer _healthPlayer;
	private ActionsTurell _actionsTurell;

	private void Awake()
	{
		_player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Start()
	{
		_actionsTurell = new ActionsTurell();
	}

	//RaycastHit Очень интересно работать с этими возможностями.
	//Расширяет возможности для разработки.
	private RaycastHit hit;
	private float distationRaycast = 15;
	private void Update()
	{
		NavMeshEnemy(_agent, _player);

		_actionsTurell.TrigerOnPlayer(gameObject,
			_player, hit, distationRaycast);
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
