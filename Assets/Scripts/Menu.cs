using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    // Start is called before the first frame update

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu(string menu)
    {
        ScoreKeep.currScore = 0;
        SceneManager.LoadScene(menu);
    }

    public void Instructions(string instructions)
    {
        SceneManager.LoadScene(instructions);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
