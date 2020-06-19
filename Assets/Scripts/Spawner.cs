using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject carToSpawn;
    public float time = 0;
    public int timeForSpawning = 3;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(carToSpawn, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeForSpawning)
        {
            time = 0;
            Instantiate(carToSpawn, gameObject.transform);
        }
    }
}
