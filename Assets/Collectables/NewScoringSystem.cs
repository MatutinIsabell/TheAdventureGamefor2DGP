using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScoringSystem : MonoBehaviour
{
    public GameObject GURLscoreText;
    public GameObject BOIscoreText;
   
    public static int gurlScores;
    public static int boisScores;

    void Update()
    {
        GURLscoreText.GetComponent<Text>().text = " P2 Score: " + gurlScores;
        BOIscoreText.GetComponent<Text>().text = " P1 Score: " + boisScores;
    }
}
