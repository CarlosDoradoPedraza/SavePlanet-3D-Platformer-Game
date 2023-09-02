using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public bool isTakingTime = false;
    public int theSeconds = 80;
    public static int extendScore;
    public GameObject GameOver;
    public GameObject LevelAudio;
    public GameObject fadeOut;

    void Update()
    {
        extendScore = theSeconds;
        if (theSeconds == 0)
        {
            GlobalScore.currentScore = 0;
            ResetLevel();
        }
        else if (isTakingTime == false)
        {
            StartCoroutine(SubstractSecond());
        }
    }

    IEnumerator SubstractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

    void ResetLevel()
    {
        GameOver.SetActive(true);
        LevelAudio.SetActive(false);
        StartCoroutine(LoadSceneAfterDelay("Level1", 2.0f));
    }

    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}


