using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGems : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject playerG;
    public GameObject playerB;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collectSound.Play();


        if (collision.gameObject == playerB)
        {
            NewScoringSystem.boisScores += 80;

        }
        else if (collision.gameObject == playerG)
        {
            NewScoringSystem.gurlScores += 80;

        }
       
        
            
    }



}
