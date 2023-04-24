using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
	private float _speedBullet = 2f;

	private void Update()
	{
		gameObject.transform.Translate(Vector3.forward * _speedBullet
			* Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy") | other.CompareTag("Walls"))
		{
			Destroy(gameObject);
		}
	}
}
