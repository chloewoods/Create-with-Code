using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    private float startDelay = 0;
    private float spawnRate = 1.5f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        // Spawn obstacles at specified interval
        InvokeRepeating("SpawnObstacle", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            //Spawn an obstacle at specified location and rotation
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
