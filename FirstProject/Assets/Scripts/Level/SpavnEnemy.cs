using UnityEngine;

public class SpavnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _enemyObjectSpavn;
    [SerializeField]
    private GameObject[] _spawnPoint;

	private ActionsSpavnEnemy _actionSpavn;

	private void Start()
	{
		_actionSpavn = new ActionsSpavnEnemy();
	}

	private void FixedUpdate()
	{
		
	}
}
