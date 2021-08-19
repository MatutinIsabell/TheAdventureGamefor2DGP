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


        if (collision.gameObject == playerB)
        {
            NewScoringSystem.boisScores += 6;

        }
        else if (collision.gameObject == playerG)
        {
            NewScoringSystem.gurlScores += 6;

        }



    }
}
