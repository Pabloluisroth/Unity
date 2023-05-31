using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGranade : MonoBehaviour
{
    public float throwForce = 500;
    public GameObject granadePrefab;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if(Time.time > shotRateTime && GameManager.Instance.gunAmmoGranade > 0)
            {

                GameManager.Instance.gunAmmoGranade--;

                GameObject newGranade;
                newGranade = Instantiate(granadePrefab, transform.position, transform.rotation);
                newGranade.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);

                shotRateTime = Time.time + shotRate;
            }
        }
    }

  
}
