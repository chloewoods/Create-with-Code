using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDown = 0.5f;
    private float coolDownTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        // Reduce timer
        coolDownTimer -= Time.deltaTime;

        // On spacebar press and timer has reached 0, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDownTimer <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            // Reset timer
            coolDownTimer = coolDown;
        }
    }
}
