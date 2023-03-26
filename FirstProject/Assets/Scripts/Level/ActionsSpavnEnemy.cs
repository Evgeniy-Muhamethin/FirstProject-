using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsSpavnEnemy 
{
    public void ActiveEnemyObject(GameObject[] enemyObjectActive)
    {
		foreach (GameObject elements in enemyObjectActive)
		{
			//TODO Добавить включение объекта
			//через определенное время 
			elements.SetActive(true);
		}
	}
}
