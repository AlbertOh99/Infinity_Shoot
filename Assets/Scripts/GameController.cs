using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    //var numEnemies : GameObject[];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*numEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (numEnemies.length > 1)
        {
            Debug.Log(numEnemies.length);
        }*/

        if (GameObject.FindGameObjectsWithTag("Enemies").Length > 1)
        {
            Debug.Log("There are enemies");
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
