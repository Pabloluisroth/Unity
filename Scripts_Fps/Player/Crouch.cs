using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour
{

    private float crouchHeight;
    private float standarHeight;
    private Vector3 cameraPos;
    private GameObject camara;
    private Vector3 cameraCpos;
    private CharacterController controller;
    
    void Start()
    {
        camara = GameObject.FindGameObjectWithTag("MainCamera");
        controller = GetComponent<CharacterController>();
        standarHeight = controller.height;
        crouchHeight = standarHeight / 2.5f;
        cameraPos = camara.transform.localPosition;
        cameraCpos = new Vector3(cameraPos.x, cameraPos.y / 2, cameraPos.z);
    }

    void Crouching()
    {
        if (controller.isGrounded)
        {
            controller.height = crouchHeight;
            controller.center = new Vector3(0f, -0.5f, 0f);
            camara.transform.localPosition = cameraCpos;
        }
    }

    void GetUp()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        controller.center = new Vector3(0f, 0f, 0f);
        controller.height = standarHeight;
        camara.transform.localPosition = cameraPos;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Crouching();
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            GetUp();
        }
    }
}