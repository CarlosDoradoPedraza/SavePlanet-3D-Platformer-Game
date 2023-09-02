using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    // Set this variable to the name of the scene you want to load
    public string sceneToLoad;

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar or left mouse button is pressed
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}