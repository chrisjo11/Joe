using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private Rigidbody2D monsterRB;

    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float startingProjectileDelay;

    private float projectileDelay;
    [SerializeField] private float delayIncreaseSuppression;

    [SerializeField] private AudioSource attackAudio;

    void Start()
    {
        projectileDelay = startingProjectileDelay;
        StartCoroutine("ShootRoutine");
    }

    private void Update()
    {
        projectileDelay = startingProjectileDelay / (TimerSingleton.Timer.currentTime / delayIncreaseSuppression);
    }

    IEnumerator ShootRoutine()
    {
        for(; ; )
        {
            attackAudio.Play();
            projectilePrefab.GetComponent<ProjectileScript>().setRandomProjectile();
            Instantiate(projectilePrefab, this.gameObject.transform.position + new Vector3(2.3f, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(projectileDelay);
        }
    }
}
