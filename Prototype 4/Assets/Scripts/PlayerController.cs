using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public bool hasPowerup = false;
    public float powerupStrength = 10;
    public float powerupLength = 5;
    public GameObject powerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        //reference to player rigidbody
        playerRb = GetComponent<Rigidbody>();
        //reference to focal point game object
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        //Move player based on vertical input and focal point position
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput *  speed);

        //set powerup indicator to player position
        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.6f,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if player collides with powerup, destroy powerup and set powerup condition to true
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            // turn on power up indicator
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            // start countdown for power to turn off
            StartCoroutine(PowerCountdownRoutine());
        }
    }

    IEnumerator PowerCountdownRoutine()
    {
        //wait 5 seconds before turning powerup off
        yield return new WaitForSeconds(powerupLength);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            //Get enemy's rigidbody component
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();

            //Get direction that enemy should be propelled away 
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            //Apply Impulse force in direction specified
            enemyRigidBody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);

            Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerup);
        }
    }
}
