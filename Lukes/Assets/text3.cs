using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text3 : MonoBehaviour
{
    List<string> thirdchoice = new List<string>() { "Hamburg","La Paz","Bourges","Belo Horizonte","Havana" };
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = thirdchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[TextControl.randQuestion];
        }
    }
    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
