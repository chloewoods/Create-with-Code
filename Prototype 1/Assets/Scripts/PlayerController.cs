using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    public float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if there is a left or right input
        horizontalInput = Input.GetAxis("Horizontal");

        //Check if there is a up or down input
        verticalInput = Input.GetAxis("Vertical");
        
        //Move the vehicle forward depending on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Also rotate the vehicle right or left depending on input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
