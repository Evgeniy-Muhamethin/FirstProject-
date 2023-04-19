using UnityEngine;

public class MainItems : MonoBehaviour
{
	private HealthItems healthItems;

	private int _healthAdd = 1;

	private void Start()
	{
		healthItems = new HealthItems();
	}

	private int _countHealth = 15;

	private void OnTriggerStay(Collider other)
	{
		int countHealth = _countHealth;
		while (countHealth > 0)
		{
			healthItems.AddHealthPlayer(_healthAdd);
			countHealth--;
		}
		if (countHealth == 0)
		{
			Destroy(gameObject);
		}
	}
}