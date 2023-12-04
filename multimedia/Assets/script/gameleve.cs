using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class gameleve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player1"))
        SceneManager.LoadScene(2);
        if (collision.CompareTag("player2"))
            SceneManager.LoadScene(5);
        if (collision.CompareTag("player3"))
            SceneManager.LoadScene(6);
        if (collision.CompareTag("player4"))
            SceneManager.LoadScene(7);
        if (collision.CompareTag("player5"))
            SceneManager.LoadScene(8);

    }
}
