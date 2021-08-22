using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class EndSceneButtons : MonoBehaviour
{

 


    public void RestartLevel()
    {
        EditorSceneManager.LoadScene("FirstLevel");
    }

    public void GoToMainMenu()
    {
      EditorSceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

}
