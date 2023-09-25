using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour
{
    public float rotationSpeed;
    private Vector3 rotationDirection = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate propeller around z axis
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
