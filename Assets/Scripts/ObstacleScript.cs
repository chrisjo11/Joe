using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D obstacle;
    [SerializeField] private float speed;
    void Update()
    {
        obstacle.velocity = new Vector2(speed, 0);
        if(this.gameObject.transform.position.x < -12)
        {
            Destroy(this.gameObject);
        }
    }
}
