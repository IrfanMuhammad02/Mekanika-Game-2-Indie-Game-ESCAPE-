using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NyawaScript : MonoBehaviour
{
    [SerializeField]
    Slider healthBar;
    public float currentHealth = 100;
   
    
    public static bool gameOver;

    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        healthBar.value = currentHealth;
        gameOver = false;
  
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Monster")
        {
            currentHealth -= 20f;           
        }

        if(other.tag == "Bunga")
        {
            currentHealth += 6f;
        }

        if(other.tag == "Jamur")
        {
            currentHealth += 12f;
        }

        if(other.tag == "PUMER")
        {
            currentHealth -= 30f;           
        }

        if(other.tag == "PUNGU")
        {
            currentHealth -= 25f;           
        }

        //slider 
        if(other.tag == "Monster")
        {
            healthBar.value -= 20f;           
        }

        if(other.tag == "Bunga")
        {
            healthBar.value += 6f;
        }

        if(other.tag == "Jamur")
        {
            healthBar.value += 12f;
        }

        if(other.tag == "PUMER")
        {
            healthBar.value -= 30f;           
        }

        if(other.tag == "PUNGU")
        {
            healthBar.value -= 25f;           
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (currentHealth < 0 )
        {
            Time.timeScale = 0;
            gameOver = true;
            gameOverPanel.SetActive(true);
        }

    }
}
