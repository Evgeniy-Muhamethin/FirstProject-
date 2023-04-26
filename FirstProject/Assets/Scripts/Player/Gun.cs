using System;
using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour //�� ����� ��� �������� ��� MonoBehaviour 
{
    private GameObject SpawnBullet(Transform pointSpawnObject, 
        GameObject spawnObject)
    {
        return Instantiate(spawnObject, 
            pointSpawnObject.position, pointSpawnObject.transform.rotation);
    }

    Coroutine _coroutine;
    private int _secondsWait = 10;

    public void ButtonGun(KeyCode button, Transform pointSpawnObject,
		GameObject spawnObject)
    {
        if (Input.GetKeyDown(button))
        {
            //TODO ����� ������ �������� � ������� ��� ��� ���� 
            //TODO � ����� �������� � ��������� 
            _coroutine = StartCoroutine(ButtonGunCreated(pointSpawnObject, 
                spawnObject));
		}
        else if (Input.GetKeyUp(button))
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator ButtonGunCreated(Transform pointSpawnObject,
		GameObject spawnObject)
    {
		SpawnBullet(pointSpawnObject, spawnObject);
		yield return new WaitForSeconds(_secondsWait);
    }
}
