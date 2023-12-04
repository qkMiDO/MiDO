using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score4 : MonoBehaviour
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
    public static int scor4 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor4.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor4 == 4) Destroy(pnal1);
        else if (scor4 == 8) Destroy(pnal2);
        else if (scor4 == 12) Destroy(pnal3);
        else if (scor4 == 16) Destroy(pnal4);
        else if (scor4 == 20) Destroy(pnal5);
        else if (scor4 == 24) Destroy(pnal6);
        else if (scor4 == 28) Destroy(pnal7);
        else if (scor4 == 32) Destroy(pnal8);
        else if (scor4 == 36) Destroy(pnal9);
        else if (scor4 == 40) Destroy(pnal10);
        else if (scor4 == 44) Destroy(pnal11);
        else if (scor4 == 48) Destroy(pnal12);

        scor4 = 0;
    }
}
