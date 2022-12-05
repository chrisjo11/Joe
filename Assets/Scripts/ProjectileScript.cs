using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private Sprite[] sprites;
    private GameObject player;
    private Projectile projectile;

    private void Start()
    {
        projectile = new Projectile((ProjectileType)(Random.Range(1, 4) * 10));
        switch(projectile.projectileType)
        {
            case ProjectileType.RED:
                renderer.sprite = sprites[0];
                break;
            case ProjectileType.BLUE:
                renderer.sprite = sprites[1];
                break;
            case ProjectileType.GREEN:
                renderer.sprite = sprites[2];
                break;
            case ProjectileType.PURPLE:
                renderer.sprite = sprites[3];
                break;
        }
        player = GameObject.Find("Martin");
    }

    private void Update()
    {
        float yVelocity = player.transform.position.y - this.gameObject.transform.position.y;
        rb.velocity = new Vector2(speed, yVelocity);

        if (this.gameObject.transform.position.x > 15)
        {
            Destroy(this.gameObject);
        }
    }

    public Projectile setRandomProjectile()
    {
        projectile = new Projectile((ProjectileType) (Random.Range(1, 4) * 10));
        return projectile;
    }

    public Projectile getProjectile()
    {
        return projectile;
    }
}
