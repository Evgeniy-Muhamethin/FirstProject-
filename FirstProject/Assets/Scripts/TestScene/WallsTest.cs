using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsTest : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Bullet"))
		{
			gameObject.SetActive(false);
		}
	}
}
