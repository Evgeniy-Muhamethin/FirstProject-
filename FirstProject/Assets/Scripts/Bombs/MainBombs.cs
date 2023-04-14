using UnityEngine;

public class MainBombs : MonoBehaviour
{
    private ActionBombs _actionBombs;

	void Start()
    {
        _actionBombs = new ActionBombs();
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
        {
            _actionBombs.DestroyObject(gameObject);
        }
	}
}