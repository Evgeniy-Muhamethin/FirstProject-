using UnityEngine;

public class SpavnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _enemyObjectSpavn;

	private ActionsSpavnEnemy _actionSpavn;

	private void Start()
	{
		_actionSpavn = new ActionsSpavnEnemy();
	}

	private void FixedUpdate()
	{
		_actionSpavn.ActiveEnemyObject(_enemyObjectSpavn);
	}
}
