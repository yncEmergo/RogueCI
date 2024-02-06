using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int Health { get; private set; }

    public Character(int initialHealth)
    {
        Health = initialHealth;
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
            Health = 0;
    }
}