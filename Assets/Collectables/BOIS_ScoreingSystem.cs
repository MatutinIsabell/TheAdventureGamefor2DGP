using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOIS_ScoreingSystem : MonoBehaviour
{
    public GameObject BOIscoreText;
    public static int boisScores;

    void Update()
    {
        BOIscoreText.GetComponent<Text>().text = " Score: " + boisScores;
        
    }
}
