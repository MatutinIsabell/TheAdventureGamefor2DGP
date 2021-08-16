using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GURLS_ScoringSystem : MonoBehaviour
{
    public GameObject GURLscoreText;
    public static int gurlScores;

    void Update()
    {
       GURLscoreText.GetComponent<Text>().text = " Score: " + gurlScores;
    }


}
