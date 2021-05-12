using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float aliveTime;
    public int damage;
    public float movSpeed;


    public GameObject facing;
    private GameObject playerTrigger;
    private GameObject groundTrigger;
    private PlayerMovement playerInfo;

    // Start is called before the first frame update
    void Start()
    {
        facing = GameObject.Find("FirstPerson");
        transform.LookAt(facing.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
        aliveTime -= 1 * Time.deltaTime;

        if (aliveTime <= 0)
        {
            Destroy(this.gameObject);
        }

        //transform.LookAt(facing.transform);
        this.transform.Translate(Vector3.forward * Time.deltaTime * movSpeed);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HealthBar.instance.health();
            playerTrigger = other.gameObject;
            playerTrigger.GetComponent<PlayerMovement>().HP -= damage;
            Destroy(this.gameObject);
        }
        if (other.tag == "Ground")
        {
            groundTrigger = other.gameObject;
            Destroy(this.gameObject);
        }
    }
}

