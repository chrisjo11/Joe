using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacleTop;
    [SerializeField] private GameObject obstacleBottom;
    [SerializeField] private float spawnDelay;

    private Vector3 obstaclePosTop;
    private Vector3 obstaclePosBottom;

    private float scaleTop;
    private float scaleBottom;
    
    void Start()
    {
        
        obstaclePosTop = new Vector3(16, 5, 0);
        obstaclePosBottom = new Vector3(12, -5, 0);
        StartCoroutine("SpawnRoutine");
    }

    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        for (; ; )
        {
            scaleTop = Random.Range(2f, 5f);
            scaleBottom = Random.Range(2f, 5f);

            obstacleTop.transform.localScale = new Vector3(obstacleTop.transform.localScale.x, scaleTop/2, 1);
            Instantiate(obstacleTop, obstaclePosTop, Quaternion.identity);

            obstacleBottom.transform.localScale = new Vector3(obstacleBottom.transform.localScale.x, scaleBottom/2, 1);
            Instantiate(obstacleBottom, obstaclePosBottom, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
