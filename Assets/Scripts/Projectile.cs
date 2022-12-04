using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    private ProjectileType projectile;

    public Projectile(ProjectileType projectile)
    {
        this.projectile = projectile;
    }

    public float Damage
    {
        get { return (float) projectile; }
    }

    public ProjectileType projectileType
    {
        get { return projectile; }
    }

    
}
