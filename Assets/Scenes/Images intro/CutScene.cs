using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public float changeTime; // A variable to store the time until the scene changes
    public string Level1; // The name of the scene to load

    // Start is called before the first frame update
    void Start()
    {
        // Do any setup you need here
    }

    // Update is called once per frame
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        changeTime -= Time.deltaTime; // Decrease the time until the scene changes by the time since the last frame

        if (changeTime <= 0)
        {
            SceneManager.LoadScene(Level1); // Load the scene named Level1
        }
    }
}
