using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingFood : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
       collectSound.Play();
       ScoreSystem.bothScores += 6;
    }
}
