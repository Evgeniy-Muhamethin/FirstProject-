using UnityEngine;

public class ActionsSpavnEnemy 
{
    //TODO �������� ������ � ����������� ������ �����

    public void Spawn(GameObject gameObjects, 
        GameObject spawnPoint)
    {
        gameObjects.SetActive(true);
        spawnPoint.transform.position = gameObjects.transform.position;
    }
}