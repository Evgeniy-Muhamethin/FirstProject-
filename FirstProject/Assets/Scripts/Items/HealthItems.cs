using UnityEngine;

public class HealthItems
{
    private HealthPlayer _playerHealth;

    public void AddHealthPlayer(int healthAdd)
    {
        _playerHealth.Health += healthAdd;
    }
}
