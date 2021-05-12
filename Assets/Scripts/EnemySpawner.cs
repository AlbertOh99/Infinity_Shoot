using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public static EnemySpawner instance;

    public GameObject enemy;
    private int xPosition;
    private int yPosition;
    private int zPosition;
    public int maxEnemies;
    public int spawnCountdown;
    private int spawnRate = 0;
    public int currEnemies = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currEnemies <= maxEnemies && spawnRate >= spawnCountdown)
        {
            xPosition = Random.Range(-19, 12);
            yPosition = Random.Range(5, 18);
            zPosition = Random.Range(-25, 13);
            Instantiate(enemy, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
            currEnemies += 1;
            spawnRate = 0;
        }

        spawnRate += 1;
    }
}
