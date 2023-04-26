using UnityEngine;

public struct DataEnemy 
{
    private static int _health;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
}
