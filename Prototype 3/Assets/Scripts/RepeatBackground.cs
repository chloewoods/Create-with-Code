using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //Set variables at start of game
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Move background back to start position after it has moved half its length
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }

    }
}
