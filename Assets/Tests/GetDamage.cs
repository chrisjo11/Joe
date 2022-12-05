using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GetDamage
{
    // A Test behaves as an ordinary method
    [Test]
    public void blueProjectileTest()
    {
        Projectile p2 = new Projectile(ProjectileType.BLUE);
        Assert.AreEqual(30, p2.Damage);
    }
    [Test]
    public void redProjectileTest()
    {
        Projectile p1 = new Projectile(ProjectileType.RED);
        Assert.AreEqual(20, p1.Damage);
    }
    [Test]
    public void greenProjectileTest()
    {
        Projectile p1 = new Projectile(ProjectileType.GREEN);
        Assert.AreEqual(10, p1.Damage);
    }
    [Test]
    public void purpleProjectileTest()
    {
        Projectile p1 = new Projectile(ProjectileType.PURPLE);
        Assert.AreEqual(40, p1.Damage);
    }



}
