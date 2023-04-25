using System;
using UnityEngine;

public class Gun
{
    private GameObject SpawnBullet(Transform pointSpawnObject, 
        GameObject spawnObject)
    {
        return MonoBehaviour.Instantiate(spawnObject, 
            pointSpawnObject.position, pointSpawnObject.transform.rotation);
    }

    public void ButtonGun(KeyCode button, Transform pointSpawnObject,
		GameObject spawnObject)
    {
        if (Input.GetKey(button))
        {
            SpawnBullet(pointSpawnObject, spawnObject);
		}
    }
}
