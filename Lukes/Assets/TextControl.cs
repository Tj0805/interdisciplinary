using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour
{

    List<string> questions = new List<string>() { "What is the capital of Germany?", "What is the capital of Mexico?", "What is the capital of France", "What is the capital of Brazil?", "What is the capital of Cuba?" };

    List<string> correctAnswer = new List<string>() { "4", "1", "2", "4", "3" };

    public Transform resultObj;

    public static string selectedAnswer;

    public static string choiceSelected = "n";

    public static int randQuestion = -1;

    public int catMod = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (selectCat.catTopic == "Algebra")
        {
            catMod = 5;
        }

        if (selectCat.catTopic == "Capitals")
        {
            catMod = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0+catMod, 5+catMod);
        }
        if (randQuestion > -1)
        {
            GetComponent<TextMesh>().text = questions[randQuestion];
        }
        //Debug.Log(questions[randQuestion]);

        if (choiceSelected == "y")
        {

            choiceSelected = "n";

            if (correctAnswer[randQuestion] == selectedAnswer)
            {
                resultObj.GetComponent<TextMesh>().text = "Correct! Click nect to continue";
            }

        }
    }
}