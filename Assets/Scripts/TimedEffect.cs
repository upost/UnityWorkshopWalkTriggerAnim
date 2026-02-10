using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class TimedEffect : MonoBehaviour
{
    public float Duration = 1;

    public Dictionary<string,string> gameStatus;

    private float startTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Duration;
    }

    // Update is called once per frame
    void Update()  
    {
        startTime-=Time.deltaTime;
        if(startTime<=0 && gameObject.activeSelf)
        {
            //gameObject.SetActive(false);
            EmissionModule em = GetComponent<ParticleSystem>().emission;
            em.enabled = false;
        }
    }
}
