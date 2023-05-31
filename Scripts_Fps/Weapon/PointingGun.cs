using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointingGun : MonoBehaviour
{
    public Transform trArma;

    private Vector3 v3;
    private float f1;

    public Vector3 posNormal;
    public Vector3 posApuntado;
    public float fovApuntado;
    public float fovNormal;
    public Camera camara;
    public float velApuntar;

    void Start()
    {
        camara = Camera.main;
    }

    void Update()
    {
        if(Input.GetKey("mouse 1"))
        {
            trArma.localPosition = Vector3.SmoothDamp(trArma.localPosition, posApuntado, ref v3, velApuntar);
            camara.fieldOfView = Mathf.SmoothDamp(camara.fieldOfView, fovApuntado, ref f1, velApuntar);
        }
        else
        {
            trArma.localPosition = Vector3.SmoothDamp(trArma.localPosition, posNormal, ref v3, velApuntar);
            camara.fieldOfView = Mathf.SmoothDamp(camara.fieldOfView, fovNormal, ref f1, velApuntar);
        }
    }
}
