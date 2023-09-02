using UnityEngine.SceneManagement;
using UnityEngine;
using Cinemachine;
using TMPro;
using System.Collections;

public class PlayerManager2 : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            StartCoroutine(RestartLevel2());
        }
    }

    IEnumerator RestartLevel2()
    {
        yield return new WaitForSeconds(3f);
        gameOverScreen.SetActive(false);
        isGameOver = false;
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene("level2");
    }
}
