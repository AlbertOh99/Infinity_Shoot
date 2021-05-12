using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public static HealthBar instance;

    public Text hpText;
    private int currentHealth;
    //private float maxHealth = 100f;
    public GameObject Player;
    

    private void Awake()
    {
        instance = this;
        
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Player.GetComponent<PlayerMovement>().HP;
        Debug.Log(currentHealth);
        hpText.text = "Health: " + currentHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void health()
    {
        currentHealth = Player.GetComponent<PlayerMovement>().HP;
        hpText.text = "Health: " + currentHealth.ToString();
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
