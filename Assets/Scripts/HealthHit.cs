using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthHit : MonoBehaviour
{
    public AudioSource hitSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager.health--;
            hitSound.Play();
            if (HealthManager.health <= 0)
            {
                //StartCoroutine(GameOver());
                PlayerManager.isGameOver = true;
            }
        }
    }
}
