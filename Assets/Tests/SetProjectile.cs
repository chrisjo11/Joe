using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SetProjectile
{
    // A Test behaves as an ordinary method
    [Test]
    public void SetRandomProjectile()
    {
        ProjectileScript p = new ProjectileScript();
        Projectile p1 = p.setRandomProjectile();
        Assert.IsNotNull(p1.projectileType);
    }

    [Test]
    public void SetTwoRandomProjectiles()
    {
        ProjectileScript p = new ProjectileScript();
        Projectile p1 = p.setRandomProjectile();
        Assert.IsNotNull(p1.projectileType);

        ProjectileScript p2 = new ProjectileScript();
        Projectile p3 = p2.setRandomProjectile();
        Assert.IsNotNull(p3.projectileType);
    }
    
}
