using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] dogsPrefabs;

    [SerializeField] float spawnLimitXLeft = -35.6f;
    [SerializeField] float spawnLimitXRight = 7;
    [SerializeField] float spawnPosY = 30;

    [SerializeField] float startDelay = 1.0f;
    [SerializeField] float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(dogsPrefabs[0], spawnPos, dogsPrefabs[0].transform.rotation);
    }

}
