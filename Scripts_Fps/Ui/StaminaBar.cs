using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider staminaSlider;
    public float maxStamina = 200;
    private float currentStamina;
    private float regenerateStaminaTime = 0.1f;
    private float regenerateAmount = 2;
    private float losingStaminaTime = 0.1f;

    void Start()
    {
        currentStamina = maxStamina;
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = maxStamina;
    }

    public void UseStamina(float amount)
    {
        if (currentStamina-amount>0)
        {
            StartCoroutine(LosingStaminaCoroutine(amount));
            StartCoroutine(RegenerateStaminaCoroutine());
        }
        else
        {
            Debug.Log("No tenemos Stamina");
        }
    }

    private IEnumerator LosingStaminaCoroutine(float amount)
    {
        while(currentStamina >= 0)
        {
            currentStamina -= amount;
            staminaSlider.value = currentStamina;
            yield return new WaitForSeconds(losingStaminaTime);
        }

        FindObjectOfType<PlayerMovement>().isSprinting = false;
    }

    private IEnumerator RegenerateStaminaCoroutine()
    {
        yield return new WaitForSeconds(1);

        while (currentStamina < maxStamina)
        {
            currentStamina += regenerateAmount;
            staminaSlider.value = currentStamina;
            yield return new WaitForSeconds(regenerateStaminaTime);
        }
    }
}
