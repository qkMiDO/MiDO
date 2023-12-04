
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score2 : MonoBehaviour
{
    public GameObject pnal1;
    public GameObject pnal2;
    public GameObject pnal3;
    public GameObject pnal4;
    public GameObject pnal5;
    public GameObject pnal6;
    public GameObject pnal7;
    public GameObject pnal8;
    public GameObject pnal9;
    public GameObject pnal10;
    public GameObject pnal11;
    public GameObject pnal12;
    Text Text;
    public static int scor2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor2.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor2 == 2) Destroy(pnal1);
        else if (scor2 == 4) Destroy(pnal2);
        else if (scor2 == 6) Destroy(pnal3);
        else if (scor2 == 8) Destroy(pnal4);
        else if (scor2 == 10) Destroy(pnal5);
        else if (scor2 == 12) Destroy(pnal6);
        else if (scor2 == 14) Destroy(pnal7);
        else if (scor2 == 16) Destroy(pnal8);
        else if (scor2 == 18) Destroy(pnal9);
        else if (scor2 == 20) Destroy(pnal10);
        else if (scor2 == 22) Destroy(pnal11);
        else if (scor2 == 24) Destroy(pnal12);

        scor2 = 0;
    }

}