using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (gameObject.CompareTag("Agressive"))
        {
            Debug.Log("Game Over due to Moose");
        }
        
    }
}
