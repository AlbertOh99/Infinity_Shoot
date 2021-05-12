using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;
    private float fireReady;
    private Transform _bullet;
    public AudioSource lazerSound;

    void start()
    {
        lazerSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        fireReady -= 1;
        if (Input.GetMouseButtonDown(0) && fireReady <= 0)
        {
            
            Fire();
        }
    }

    public void Fire()
    {
        lazerSound.Play();
        _bullet = Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);
        fireReady = fireRate;
    }

}
