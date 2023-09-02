using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRotate : MonoBehaviour
{
    public float rotationSpeed = 10f; // Set the rotation speed in the Inspector

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // Rotate the object around the Y axis
    }
}
