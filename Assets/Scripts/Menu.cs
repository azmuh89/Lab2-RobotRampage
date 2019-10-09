using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // loads the Battle scene
    public void StartGame()
    {
        SceneManager.LoadScene("Battle");
    }
    // exits the app
    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
