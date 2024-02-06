using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestCharacter
{
    [Test]
    public void ApplyDamage_ReduceHealth_HealthReduced()
    {
        var character = new Character(100);

        character.ApplyDamage(30);

        Assert.AreEqual(70, character.Health);
    }

    [Test]
    public void ApplyDamage_DamageExceedsCurrentHealth_HealthIsZero()
    {
        var character = new Character(50);

        character.ApplyDamage(60);

        Assert.AreEqual(0, character.Health);
    }
}
