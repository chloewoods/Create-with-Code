using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method to destroy objects when they collide
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            gameManager.AddScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (gameObject.CompareTag("Agressive"))
        {
            gameManager.LoseLives(1);
            Destroy(other.gameObject);
        }
        
    }
}
