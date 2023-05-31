using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Text ammoText;
    public Text healthText;
    public Text granadeText;
    public Text ShotgunText;  
    
    public int health = 100;
    public int gunAmmo = 12;
    public int gunAmmoGranade = 2; 
  
    // instanciar granadas en interface 

   private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
        granadeText.text = gunAmmoGranade.ToString();  
    }

    public void LoseHealth(int healthToReduce)  // metodo --- Perder vida Caer 
    {
        health -= healthToReduce;
        CheckHealth();
    }

    public void CheckHealth()  // Metodo --- Reiniciar al morir 
    {
        if(health <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }

}
