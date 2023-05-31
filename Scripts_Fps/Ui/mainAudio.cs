using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainAudio : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void SceneVideo()
    {
        SceneManager.LoadScene("Video");
    }

    public void SceneController()
    {
        SceneManager.LoadScene("Controller");
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
