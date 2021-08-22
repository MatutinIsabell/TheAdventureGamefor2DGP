using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingFood : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject playerG;
    public GameObject playerB;


    private void Start()
    {
        playerG = GameObject.FindGameObjectWithTag("playerGURL");
        playerB = GameObject.FindGameObjectWithTag("playerBOI");
        collectSound = GameObject.FindGameObjectWithTag("AUDIO_Food").GetComponent<AudioSource>();
    }



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
