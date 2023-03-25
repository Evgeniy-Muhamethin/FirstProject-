using Assets.Scripts.Level;
using UnityEngine;

public class Flag : MonoBehaviour
{
	public GameObject _gameObject;

	private DataLevel _dataLevel;

	private void FixedUpdate()
	{
		if (_dataLevel.MaxEnemyCount == _dataLevel.MaxEnemyCountConst)
		{
			//gameObject.GetComponent<SpavnEnemy>().enabled = false;
			_gameObject.SetActive( false );
		}
		else
		{
			_dataLevel.MaxEnemyCount++;
			//gameObject.GetComponent<SpavnEnemy>().enabled = true;
			_gameObject.SetActive(true);
		}
	}
}
