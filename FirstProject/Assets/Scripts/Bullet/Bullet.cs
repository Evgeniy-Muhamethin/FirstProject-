using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void Update()
	{
		gameObject.transform.Translate(Vector3.forward * 
			Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
