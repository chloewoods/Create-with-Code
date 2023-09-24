using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Reference to the Vehicle GameObject (here called player)
    public GameObject player;
    private int cameraMode;

    // Initialise vectors determining camera position and rotation for cameraMode 0
    private Vector3 behindOffset = new Vector3(0, 9.5f, -10.5f);
    private Vector3 behindAngle = new Vector3(28, 0, 0);

    // Initialise vectors determining camera position and rotation for cameraMode 1
    private Vector3 frontOffset = new Vector3(0, 2.5f, 5);
    private Vector3 frontAngle = new Vector3(9.5f, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        cameraMode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // If space key is pressed, change cameraMode
        if (Input.GetKeyDown("space"))
        {
            if (cameraMode == 0)
            {
                cameraMode = 1;
            }
            else
            {
                cameraMode = 0;
            }
        }
    }
    void LateUpdate()
    {
        if (cameraMode == 0) {
            // Position the camera behind vehicle by adding to the player's position and setting angle
            transform.position = player.transform.position + behindOffset;
            transform.rotation = Quaternion.Euler(behindAngle);
        }
        else
        {
            // Position the camera at front of vehicle by adding to the player's position and setting angle
            transform.position = player.transform.position + frontOffset;
            transform.rotation = Quaternion.Euler(frontAngle);
        }
    }
}
