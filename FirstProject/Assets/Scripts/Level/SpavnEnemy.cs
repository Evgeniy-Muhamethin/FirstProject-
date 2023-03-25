using Assets.Scripts.Level;
using UnityEngine;

public class SpavnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyObjectSpavn;

	private void FixedUpdate()
	{
		int count = 1000;
		while (count > 0)
		{
			count --;
		}

		if (count == 0)
		{
			Instantiate(_enemyObjectSpavn);
		}
	}
}
