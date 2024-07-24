using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4;
    private float timer = 0;
    private float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float loestPoint = transform.position.y - heightOffset + 0.5f;
        float highestPoimt = transform.position.y + heightOffset + 0.5f;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(loestPoint, highestPoimt), 0), transform.rotation);

    }
}
