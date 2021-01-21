using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menang : MonoBehaviour
{
    [SerializeField]
    Slider menang;
    public float nyawa = 100;
    
    public static bool gameOver;

    public GameObject gameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        menang.value = nyawa;
        gameOver = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Gate")
        {
            nyawa -= 1000f;
        }
    }
        // Update is called once per frame
        void Update()
    {
        if (nyawa < 0)
        {
            Time.timeScale = 0;
            gameOver = true;
            gameWinPanel.SetActive(true);
        }

    }
}
