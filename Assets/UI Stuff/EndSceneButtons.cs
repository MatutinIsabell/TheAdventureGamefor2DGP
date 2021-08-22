using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneButtons : MonoBehaviour
{
    
    public void RestartLevel()
    {
      SceneManager.LoadScene("FirstLevel");
        
    }

    public void GoToMainMenu()
    {
      SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

}
