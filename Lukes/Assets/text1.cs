using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text1 : MonoBehaviour
{
    List<string> firstchoice = new List<string>() { "Frankfurt","Mexico City","Dijon","Palmas","Nuevitas"};
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = firstchoice[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = firstchoice[TextControl.randQuestion];
        }
    }
     void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";

    }
}
