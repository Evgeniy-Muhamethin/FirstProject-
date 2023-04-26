using UnityEngine;

public class ActionsSpavnEnemy 
{
    //TODO Добавить канвас и отображение жизней врага

    public void Spawn(GameObject gameObjects, 
        GameObject spawnPoint)
    {
        gameObjects.SetActive(true);
        spawnPoint.transform.position = gameObjects.transform.position;
    }
}