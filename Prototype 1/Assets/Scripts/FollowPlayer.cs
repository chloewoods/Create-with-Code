using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Reference to the Vehicle GameObject (here called player)
    public GameObject player;

    // Initialise distance vector between player and camera
    private Vector3 offset = new Vector3(0, 9.5f, -10.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Position the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
