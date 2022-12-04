using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSingleton : MonoBehaviour
{
    public static TimerSingleton Timer { get; private set; }

    private void Awake()
    {
        if (Timer != null && Timer != this)
        {
            Destroy(this);
        }
        else
        {
            Timer = this;
        }
    }

    public float currentTime { get; private set; }

    private void Update()
    {
        currentTime += Time.deltaTime;
    }
}
