using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class controlPaused : MonoBehaviour
{
    //////////////////////////////////////////////////////////////////////////////// (GUARDAR ESCENA = Guardar partida)

    public void reloadScene()
    {
        SceneManager.LoadScene("Insufrible");// reiniciar escena
    }

    public void SceneOptions()
    {
        SceneManager.LoadScene("Options");// reiniciar escena
    }

    public void backToMain()
    {
        SceneManager.LoadScene("MainMenu"); // ir a menu principal  / scene      
    }

     public void exitScene()
    {
        Application.Quit(); // salir de la escena
    }
}




