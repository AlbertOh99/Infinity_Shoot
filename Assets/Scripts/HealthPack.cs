using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{

    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        
        if (other.tag == "Player")
        {
            Player = other.gameObject;
            if (Player.GetComponent<PlayerMovement>().HP >= 80)
            {
                Player.GetComponent<PlayerMovement>().HP = 100;
                Destroy(this.gameObject);
            } else
            {
                Player.GetComponent<PlayerMovement>().HP += 20;
                Destroy(this.gameObject);
            }
            HealthBar.instance.health();
        }
    }
}
