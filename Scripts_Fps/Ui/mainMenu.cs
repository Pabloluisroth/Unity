using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SceneGame()
    {
        SceneManager.LoadScene("Insufrible");
    }


    // cargar partidas guardadas

    public void SceneOptionse()
    {
        SceneManager.LoadScene("Options");
    }

    public void ExitScene()
    {
        Application.Quit();
    }
}
