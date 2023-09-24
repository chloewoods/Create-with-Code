using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherVehicles : MonoBehaviour
{
    // Declare speed of other vehicles
    private float otherSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move other vehicles forward by specified speed
        transform.Translate(Vector3.forward * Time.deltaTime * otherSpeed);
    }
}
