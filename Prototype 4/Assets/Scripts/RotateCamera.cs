using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 75;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate based on horizontal inputs
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.down, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
