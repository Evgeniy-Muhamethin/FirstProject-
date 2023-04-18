using System;
using UnityEngine;

public struct HealthPlayer
{
    private static int health;

    public int Health
    {
        get { return health; } 
        set {  health = value; }
    }
}
