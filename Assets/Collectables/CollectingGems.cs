using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGems : MonoBehaviour
{
    public AudioSource collectSound;
   
    void OnTriggerEnter2D(Collider2D collision)
    {
       collectSound.Play();
       GURLS_ScoringSystem.gurlScores += 80;
       BOIS_ScoreingSystem.boisScores += 80;
    }




}
