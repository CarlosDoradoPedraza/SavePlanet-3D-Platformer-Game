using UnityEngine.SceneManagement;
using UnityEngine;
using Cinemachine;
using TMPro;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            StartCoroutine(RestartLevel());
        }
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(3f);
        gameOverScreen.SetActive(false);
        isGameOver = false;
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene("level1");
    }
}
