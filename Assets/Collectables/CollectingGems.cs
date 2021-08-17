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
        if (collision.gameObject == playerB)
        {
            BOIS_ScoreingSystem.boisScores += 80;

        }

        collectSound.Play();

        if (collision.gameObject == playerG)
        {
            GURLS_ScoringSystem.gurlScores += 80;

        }
    }




}
