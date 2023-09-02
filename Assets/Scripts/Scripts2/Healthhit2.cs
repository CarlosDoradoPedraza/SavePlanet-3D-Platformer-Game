using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthhit2 : MonoBehaviour
{
    public AudioSource hitSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager2.health--;
            hitSound.Play();
            if (HealthManager2.health <= 0)
            {
                //StartCoroutine(GameOver());
                PlayerManager2.isGameOver = true;
            }
        }
    }
}
