using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//level 1
public class score : MonoBehaviour
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
    public static int scor=0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
     Text.text = scor.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (scor == 1) Destroy(pnal1);
        else if (scor == 2) Destroy(pnal2);
        else if (scor == 3) Destroy(pnal3);
        else if (scor == 4) Destroy(pnal4);
        else if (scor == 5) Destroy(pnal5);
        else if (scor == 6) Destroy(pnal6);
        else if (scor == 7) Destroy(pnal7);
        else if (scor == 8) Destroy(pnal8);
        else if (scor == 9) Destroy(pnal9);
        else if (scor == 10) Destroy(pnal10);
        else if (scor == 11) Destroy(pnal11);
        else if (scor == 12) Destroy(pnal12);

        scor = 0;
    }
}
