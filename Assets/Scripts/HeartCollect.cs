using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class HeartCollect : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 10;
        collectSound.Play();
        Destroy(gameObject);
    }
    
}
