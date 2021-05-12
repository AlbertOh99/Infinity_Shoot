using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float aliveTime;
    public float damage;
    public float movSpeed;


    public GameObject bulletSpawn;
    private GameObject enemyTrigger;
    private GameObject groundTrigger;

    // Start is called before the first frame update
    void Start()
    {
        bulletSpawn = GameObject.Find("BulletSpawn");
        this.transform.rotation = bulletSpawn.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        aliveTime -= 1 * Time.deltaTime;

        if(aliveTime <= 0)
        {
            Destroy(this.gameObject);
        }

        
        this.transform.Translate(Vector3.forward * Time.deltaTime * movSpeed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemies")
        {
            enemyTrigger = other.gameObject;
            enemyTrigger.GetComponent<Enemy>().health -= damage;
            Destroy(this.gameObject);
        }else if(other.tag == "Ground")
        {
            groundTrigger = other.gameObject;
            Destroy(this.gameObject);
        }
    }
}

