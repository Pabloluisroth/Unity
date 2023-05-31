using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour // interaccion con caja de reposicion
{
    public Transform startPosition;


  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GunAmmo"))
        {
            GameManager.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;  // Destruir caja de municion al recarga de ( AmmoBox ) --------  Balas de armas
            Destroy(other.gameObject);

            GameManager.Instance.gunAmmoGranade += other.gameObject.GetComponent<AmmoBox>().ammoGranade;  // Destruir caja de municion al recarga de ( AmmoBox )  ---------- Granadas
            Destroy(other.gameObject);




        }

        if(other.gameObject.CompareTag("DeathFloor")) // Perder vida al colisionar contra el suelo ( planeDeath )
        {
       
            GameManager.Instance.LoseHealth(90); // Cantidad de vida perdida

            GetComponent<CharacterController>().enabled = false;  // respawn
            gameObject.transform.position = startPosition.position;
            GetComponent<CharacterController>().enabled = true;
        }
        
    }
  
}
