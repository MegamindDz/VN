using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s1 : MonoBehaviour
{
    public TextAsset textFile;
    string[] line = new string[5];
    string[] names = { "Hina" , "Midoriya" };
    Text textDisplay;
    int currentline = 0;
    // Start is called before the first frame update
    void Start()
    {
        string alltext = textFile.text;
        line = alltext.Split("\n");
        textDisplay = GameObject.Find("Text").GetComponent<Text>();
        displayText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentline++;
            displayText();

        }    
        

    }
    void displayText()
    {
        string[] tmp = new string[2];
        tmp = line[currentline].Split(":");
        int cNumber = int.Parse(tmp[0]);
        string txt = "";
        txt = names[cNumber] + " : " + tmp[1];
        textDisplay.text = txt;

    }
}

