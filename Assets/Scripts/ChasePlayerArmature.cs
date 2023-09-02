using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerArmature : MonoBehaviour
{
    public Transform target; // The PlayerArmature's transform
    public float moveSpeed = 5f; // The speed at which the AI should move towards the PlayerArmature
    public float chaseRange = 10f; // The range within which the AI should chase the PlayerArmature

    private Vector3 movementDirection; // The current direction of movement

    void Update()
    {
        // Get the direction from the AI's current position to the PlayerArmature's position
        Vector3 direction = target.position - transform.position;
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget <= chaseRange)
        {
            // Get the direction from the AI's current position to the PlayerArmature's position
            Vector3 distance = target.position - transform.position;
            // Normalize the direction vector to get a unit vector in the direction of the PlayerArmature
            direction.Normalize();

            // Update the direction of movement based on the direction to the PlayerArmature
            movementDirection = direction;

            // Move the AI in the direction of movement
            transform.position += movementDirection * moveSpeed * Time.deltaTime;

            // Rotate the AI to face the direction of movement
            transform.rotation = Quaternion.LookRotation(movementDirection, Vector3.up);
        }
    }
}
