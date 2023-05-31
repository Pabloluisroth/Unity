using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFusil : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;

    public float shotForce = 6000f;
    public float shotRate = 0.9f;

    private float shotRateTime = 0;

    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) == true)
           
       /* else if (Input.GetKey("Mouse0") == false)*/

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
