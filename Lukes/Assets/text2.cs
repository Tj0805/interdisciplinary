using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text2 : MonoBehaviour
{
    List<string> secondchoice = new List<string>() { "Cologne", "Chihuahua", "Paris", "Teresina", "Holguin" };
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = secondchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[TextControl.randQuestion];
        }
    }
    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}