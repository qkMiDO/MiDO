using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class che : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        { 
            Destroy(player);
            SceneManager.LoadScene(4);
        }
    }
}