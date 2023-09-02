using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject ScoreBox;
    public static int currentScore;
    public int internalScore;


    // Update is called once per frame
    void Update()
    {
        internalScore = currentScore;
        ScoreBox.GetComponent<Text>().text = "" + internalScore;
    }
}
