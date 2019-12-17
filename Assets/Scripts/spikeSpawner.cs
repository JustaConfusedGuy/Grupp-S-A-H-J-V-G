﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeSpawner : MonoBehaviour
{
    public Transform Spike;
    [SerializeField]
    public float elapsedTime = 0.0f;
    [SerializeField]
    public float respawnTimer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > respawnTimer)
        {
            Vector2 position = new Vector2(Random.Range(5, 50), Random.Range(9, 8));
            Instantiate(Spike, position, Quaternion.identity);
            elapsedTime = 0;
        }
    }
}