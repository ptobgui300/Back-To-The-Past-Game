using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    
    public static int maxHealth = 3;
    public static int currentHealth = maxHealth;
    public TextMeshProUGUI healthText;


    public void Start()
    {
        healthText.text = "Lives: " + currentHealth;
    }

    public void Damage(int damageGiven)
    {
        
        currentHealth -= damageGiven;
        updateHealth(currentHealth);
    }

    private void updateHealth(int resultingHealth)
    {

        if (resultingHealth <= 0)
        {
            
            
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("GameOver");
            currentHealth = maxHealth;
        }
        else
        {
            healthText.text = "Lives: " + currentHealth;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
