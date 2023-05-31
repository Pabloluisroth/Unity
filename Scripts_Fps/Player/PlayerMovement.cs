using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// movimiento jugador

public class PlayerMovement : MonoBehaviour
{
   
public CharacterController characterController;
public float speed = 9f;
public Transform groundCheck;
public float sphereRadius = 0.3f;
public LayerMask groundMask;
bool isGrounded;
public float gravity = -9.91f;
Vector3 velocity;
public float jumpHeight = 1;
public bool isSprinting;
public float sprintingSpeedMultiplier = 1.6f;
private float sprintSpeed = 1;
public float staminaUseAmount = 5;
private StaminaBar staminaSlider;
public Animator animator;    
    
    private void Start()
    {
        staminaSlider = FindObjectOfType<StaminaBar>();
    }
   
   
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,sphereRadius,groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

    animator.SetFloat("VelX",x);
    animator.SetFloat("VelZ",z);





        Vector3 move = transform.right * x + transform.forward * z;

        JumpCheck();
        RunCheck();

        characterController.Move(move * speed * Time.deltaTime * sprintSpeed);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
   }

    public void JumpCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -1 * gravity);
        }
    }

    public void RunCheck()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = !isSprinting;
        }

        if(isSprinting == true)
        {
            sprintSpeed = sprintingSpeedMultiplier;

            staminaSlider.UseStamina(staminaUseAmount); 
        }
       
        else
        {
            sprintSpeed = 1;
            staminaSlider.UseStamina(0);
        } 
    }
}
