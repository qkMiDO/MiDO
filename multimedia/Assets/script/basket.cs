
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
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
        if (collision.CompareTag("player2"))
        {   
            score2.scor2 += 10;

            Destroy(gameObject);
        }
        if (collision.CompareTag("player3"))
        {
            score3.scor3 += 10;

            Destroy(gameObject);
        }
        if (collision.CompareTag("player4"))
        {
            score4.scor4 += 10;

            Destroy(gameObject);
        }
    }
}
