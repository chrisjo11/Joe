using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DoDamage
{
    // A Test behaves as an ordinary method
    [Test]
    public void doNinetyDamage()
    {
        PlayerController p = new PlayerController();
        p.doDamage(90);
        Assert.AreEqual(160, p.getHealth());
    }

    [Test] 
    public void doZeroDamage()
    {
        PlayerController p1 = new PlayerController();
        p1.doDamage(0);
        Assert.AreEqual(p1.getMaxHealth(), p1.getHealth());
    }

    [Test]
    public void doMoreThanMaxHealthDamage()
    {
        PlayerController p = new PlayerController();
        p.doDamage(p.getMaxHealth()+1.0f);
        Assert.AreEqual(0, p.getHealth());
    }


}
