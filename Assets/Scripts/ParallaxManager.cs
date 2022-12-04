using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    [SerializeField] private GameObject[] parallaxLayers;
    [SerializeField] private GameObject[] parallaxLayers2;
    [SerializeField] private float parallaxSpeed;
    [SerializeField] private float parallaxAmount;
    private float lowBound = -22.5F;
    private float highBound = 23.73f;

    void Update()
    {
        for(int i = 0; i < parallaxLayers.Length; i++)
        {
            parallaxLayers[i].transform.position -= new Vector3(Time.deltaTime * parallaxSpeed / 100 * Mathf.Pow(i + 1, 1 + parallaxAmount / 100), 0, 0);
            if(parallaxLayers[i].transform.position.x < lowBound)
            {
                parallaxLayers[i].transform.position = new Vector3(highBound, 0,0);
            }
        }
        for (int i = 0; i < parallaxLayers2.Length; i++)
        {
            parallaxLayers2[i].transform.position -= new Vector3(Time.deltaTime * parallaxSpeed / 100 * Mathf.Pow(i + 1, 1 + parallaxAmount / 100), 0, 0);
            if (parallaxLayers2[i].transform.position.x < lowBound)
            {
                parallaxLayers2[i].transform.position = new Vector3(highBound, 0, 0);
            }
        }
    }
}
