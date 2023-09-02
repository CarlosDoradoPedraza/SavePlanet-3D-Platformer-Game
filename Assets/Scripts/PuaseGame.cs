using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuaseGame : MonoBehaviour
{
    private bool isPaused = false;
    private float previousTimeScale;
    private AudioSource[] audioSources;
    private GameObject playerCameraRoot;
    private GameObject playerArmature;
    private Vector3 originalCameraPosition;
    private Quaternion originalCameraRotation;
    public GameObject pauseMenu;

    void Start()
    {
        // Get all AudioSources in the scene
        audioSources = FindObjectsOfType<AudioSource>();
        // Get the player camera root game object
        playerCameraRoot = GameObject.Find("PlayerCameraRoot");
        // Get the player armature game object
        playerArmature = GameObject.Find("PlayerArmature");
        // Store the original camera position and rotation
        originalCameraPosition = playerCameraRoot.transform.position;
        originalCameraRotation = playerCameraRoot.transform.rotation;

    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!isPaused)
            {
                Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                Resume();
            }
        }
    }

    void Pause()
    {
        isPaused = true;
        previousTimeScale = Time.timeScale;
        Time.timeScale = 0f; // Pause the game by setting time scale to 0
        // Disable the player camera root game object to freeze the camera
        playerCameraRoot.SetActive(false);
        // Disable the entire player armature to freeze the player's movement and camera
        playerArmature.SetActive(false);
        // Pause all AudioSources
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Pause();
        }
        // Hide cursor and lock it to the center of the screen
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Resume()
    {
        isPaused = false;
        Time.timeScale = previousTimeScale; // Resume the game by restoring previous time scale
        // Enable the player camera root game object to unfreeze the camera
        playerCameraRoot.SetActive(true);
        // Enable the entire player armature to resume the player's movement and camera
        playerArmature.SetActive(true);
        // Resume all AudioSources
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.UnPause();
        }
        // Show cursor and unlock it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Resume();
    }

    public void RestartLevel()
    {
        // You'll need to replace "Level1" with the name of your level
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene("Level1");
        Resume();
    }

    public void RestartLevel2()
    {
        // You'll need to replace "Level1" with the name of your level
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene("Level2");
        Resume();
    }
    public void ExitToMainMenu()
    {
        isPaused = false;
        Time.timeScale = previousTimeScale; // Resume the game by restoring previous time scale
        // Enable the player camera root game object to unfreeze the camera
        playerCameraRoot.SetActive(true);
        // Enable the entire player armature to resume the player's movement and camera
        playerArmature.SetActive(true);
        // Resume all AudioSources
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.UnPause();
        }
        GlobalScore.currentScore = 0;
        // You'll need to replace "MainMenu" with the name of your main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}





