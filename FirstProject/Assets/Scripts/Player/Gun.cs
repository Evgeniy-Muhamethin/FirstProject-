using System;
using UnityEngine;

public class Gun
{
    private GameObject SpawnBullet(Transform pointSpawnObject, 
        GameObject spawnObject)
    {
        return MonoBehaviour.Instantiate(spawnObject, 
            pointSpawnObject.position, Quaternion.identity);
    }

    public void ButtonGun(KeyCode button, Transform pointSpawnObject,
		GameObject spawnObject)
    {
        if (Input.GetKey(button))
        {
            GameObject objectSpawn = SpawnBullet(pointSpawnObject, spawnObject);
		}
    }
}
