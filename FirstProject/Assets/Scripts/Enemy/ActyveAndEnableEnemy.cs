using UnityEngine;
using UnityEngine.AI;

public class ActyveAndEnableEnemy : MonoBehaviour
{
	[SerializeField]
	private Transform _player;
	[SerializeField]
	private NavMeshAgent _agent;

	private HealthPlayer _healthPlayer;
	private DataEnemy _dataEnemy;

	private ActionsTurell _actionsTurell;

	private int _healthEnemy = 100;

	private void Awake()
	{
		_player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Start()
	{
		_actionsTurell = new ActionsTurell();
		_dataEnemy.Health = _healthEnemy;
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

		if (_dataEnemy.Health == 0)
		{
			Destroy(gameObject);
		}
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
