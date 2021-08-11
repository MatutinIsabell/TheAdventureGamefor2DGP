using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectGemSound;


    void OnTriggerEnter2D(Collider2D collision)
    {
        collectGemSound.Play();
        theScore += 50;
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
        Destroy(gameObject);
    }
}
