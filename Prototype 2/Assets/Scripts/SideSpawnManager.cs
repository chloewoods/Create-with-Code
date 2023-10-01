using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpawnManager : MonoBehaviour
{
    // Declare array of animals
    public GameObject[] animalSidePrefabs;
    private float spawnRangeLowerZ = 0;
    private float spawnRangeTopZ = 15;
    private float spawnPosX = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSideAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomSideAnimal()
    {
        //Choose a random index from animal array
        int animalIndex = Random.Range(0, animalSidePrefabs.Length);
        int screenSide = Random.Range(0, 2)*2-1;

        Vector3 spawnPos = new Vector3(screenSide*spawnPosX, 0, Random.Range(spawnRangeLowerZ, spawnRangeTopZ));

        //Create a new animal based on index
        Instantiate(animalSidePrefabs[animalIndex], spawnPos,
            Quaternion.Euler(new Vector3(0, 90, 0) *  -screenSide));
    }
}
