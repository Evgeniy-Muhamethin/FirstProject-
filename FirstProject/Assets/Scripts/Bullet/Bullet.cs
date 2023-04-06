using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
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
		bool flagFalse;

		if (other.CompareTag("Player"))
			flagFalse = false;
		else
			flagFalse = true;

		if (flagFalse == false)
		{
			gameObject.SetActive(false);
		}
	}
}
