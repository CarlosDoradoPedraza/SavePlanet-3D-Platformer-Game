using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel2 : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject TimeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject ReturnMenu;
    public GameObject Panel;
    public GameObject Congrats;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    void OnTriggerEnter()
    {
        timeCalc = GlobalTimer2.extendScore * 100;
        TimeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer2.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }
    IEnumerator CalculateScore()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ReturnMenu.SetActive(true);
        Congrats.SetActive(true);
        Panel.SetActive(true);
        TimeLeft.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);
    }

    public void returnmenu2()
    {
        GlobalScore.currentScore = 0;
        // You'll need to replace "MainMenu" with the name of your main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}