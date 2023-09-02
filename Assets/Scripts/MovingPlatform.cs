using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f; // Speed at which the platform moves
    public float distance = 2f; // Distance the platform moves
    private float startPosition; // Starting position of the platform
    private float endPosition; // End position of the platform
    private bool movingRight = true; // Flag to indicate direction of movement
    void Start()
    {
        startPosition = transform.position.x; // Set starting position
        endPosition = startPosition + distance; // Set end position
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            // Move platform to the right
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

            // If platform has reached the end position, change direction
            if (transform.position.x >= endPosition)
            {
                movingRight = false;
            }
        }
        else
        {
            // Move platform to the left
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

            // If platform has reached the starting position, change direction
            if (transform.position.x <= startPosition)
            {
                movingRight = true;
            }
        }
    }
}
