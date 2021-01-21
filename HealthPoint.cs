using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoint : MonoBehaviour
{

  [SerializeField]
  Slider healthBar;

  public float maxHealth = 100;
  public float curHealth;

  public static bool gameOver;

  public GameObject gameOverPanel;

  void start()
  {

      healthBar.value = maxHealth;
      curHealth = healthBar.value;
  }

  void OnTriggerEnter(Collider other)
    {
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
    
    void update()
    {
        if(curHealth< 0)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
        }
    }
}
