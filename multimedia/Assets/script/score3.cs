using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score3 : MonoBehaviour
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
    public static int scor3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor3.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor3 == 3) Destroy(pnal1);
        else if (scor3 == 6) Destroy(pnal2);
        else if (scor3 == 9) Destroy(pnal3);
        else if (scor3 == 12) Destroy(pnal4);
        else if (scor3 == 15) Destroy(pnal5);
        else if (scor3 == 18) Destroy(pnal6);
        else if (scor3 == 21) Destroy(pnal7);
        else if (scor3 == 24) Destroy(pnal8);
        else if (scor3 == 27) Destroy(pnal9);
        else if (scor3 == 30) Destroy(pnal10);
        else if (scor3 == 33) Destroy(pnal11);
        else if (scor3 == 36) Destroy(pnal12);

        scor3 = 0;
    }
}
