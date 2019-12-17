using System.Collections;
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
            Vector2 position = new Vector2(Random.Range(10, 8), Random.Range(2, 0));
            elapsedTime = 0;
        }
    }
}
