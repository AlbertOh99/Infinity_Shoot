using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    
    public Transform head;
    public float followSpeed;
    public GameObject player1;

    //enemy bullet properties
    public float fireRate;
    private float fireReady;
    private Transform _bullet;
    public GameObject bullet;
    public GameObject bulletSpawn;

    public GameObject healthPack;

    public float health = 20;
    // Start is called before the first frame update
    void Start()
    {
        //player = player1.transform;
        fireReady = 800;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player1.transform);

        player1 = GameObject.Find("FirstPerson");
        transform.LookAt(player1.transform);

        fireReady -= 1;
        if (fireReady <= 0)
        {
            Fire();
        }
        //transform.position += transform.forward * 1f * Time.deltaTime;

        if (health <= 0)
        {
            die();
        }
    }


    

    public void Fire()
{
    _bullet = Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);
    fireReady = Random.Range(fireRate - 75, fireRate + 75);
}
public void die()
    {
        drops();
        Destroy(this.gameObject);
        EnemySpawner.instance.currEnemies -= 1;
        ScoreSystem.instance.Points();
    }


    public void drops()
    {
        int dropRate = Random.Range(1, 5);
        Vector3 position = transform.position;
        if(dropRate == 1)
        {
            Instantiate(healthPack, position, Quaternion.identity);
        }
    }
}
