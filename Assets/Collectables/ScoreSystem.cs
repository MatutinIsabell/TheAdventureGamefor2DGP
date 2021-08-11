using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
   // public int foodScore;
   // public int gemScore;
    public static int bothScores;



    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + bothScores;
        
    }



    //void OnTriggerEnter2D(Collider2D collision)
    //{

    //    if (collision.CompareTag("Collectable_Gems"))
    //    {
    //        print("+100");

    //    }

    //    if (collision.CompareTag("Collectable_Food"))
    //    {
    //        print("+5");

    //    }

    //}




}
