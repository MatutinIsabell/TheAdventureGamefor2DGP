using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int bothScores;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "      : " + bothScores;
    }


}
