using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;

    public float shotForce = 4200f;  
    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    // private bool hasGunFired = false;
    // [SerializeField] float gunFireDelay;
    // private Animator Recoil;

    void start()
    {
      //  Recoil = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            /* if (hasGunFired == false)
            {
                StartCoroutine(FireGun());        
            }
            */

            if (Time.time > shotRateTime && GameManager.Instance.gunAmmo > 0)
            {

                GameManager.Instance.gunAmmo--;

            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

            shotRateTime = Time.time + shotRate;

            Destroy(newBullet, 3);

             GetComponent<AudioSource>().Play();  // somido del disparo 

            }
        } 
    }
    /* IEnumerator FireGun()
        {
            hasGunFire = true;
            Recoil.Play("GunRecoil");
            yield return new WaitForSeconds(gunFireDelay);
        }
        */

}
