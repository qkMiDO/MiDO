using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public GameObject gamemenu;
    void Start()
    {

    }

    void Update()
    {
       
    }
    public void GAMEOVER() 
    {
        SceneManager.LoadScene(0);    
    
    
    }
    public void opengame()
    {
        SceneManager.LoadScene(1);
      

    }
    public void endgame()
    {
        Application.Quit();

    }
    public void GameMenu()
    {
        SceneManager.LoadScene(3);
    }
    public void continu() 
    {
        gamemenu.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
