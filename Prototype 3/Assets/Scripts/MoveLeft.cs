using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            //move object back along x axis at specified speed
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        //Destroy obstacles that move out of bounds
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) 
        {
            Destroy(gameObject);
        }
    }
}
