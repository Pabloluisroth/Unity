using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;

    public float shotForce = 4200f;
    public float shotRate = 0.9f;

    private float shotRateTime = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

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
}
