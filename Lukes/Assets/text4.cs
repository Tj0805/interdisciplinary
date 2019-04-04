using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text4 : MonoBehaviour
{
    List<string> fourthchoice = new List<string>() { "Berlin", "Sonora", "Le Mans", "Brasilia", "Bayamo" };
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = fourthchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[TextControl.randQuestion];
        }
    }
    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
