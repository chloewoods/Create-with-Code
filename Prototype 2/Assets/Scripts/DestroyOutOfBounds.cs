using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour

{

    private float zBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if abs position of object is greater than set boundary
        if (Mathf.Abs(transform.position.z) > zBound)
        {
            // Delete objetct if out of bounds
            Destroy(gameObject);
        }
    }
}
