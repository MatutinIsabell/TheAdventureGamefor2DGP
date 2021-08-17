using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingFood : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject playerG;
    public GameObject playerB;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collectSound.Play();
        GURLS_ScoringSystem.gurlScores += 6;
        BOIS_ScoreingSystem.boisScores += 6;
    }
}
