using UnityEngine;

public class ActionBombs
{
    private HealthPlayer _healthPlayer;
    private int _damage = 25;

    public void DestroyObject(GameObject gameObject)
    {
        MonoBehaviour.Destroy(gameObject);

        _healthPlayer.Health -= _damage;
    }
}