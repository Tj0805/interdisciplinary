using System.Collections;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager4 : MonoBehaviour {

      public static GameManager4 instance;
         public GameObject GameOverPanel;

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text statementText;

    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;


    void Start()
    {

    


        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        if(roundScript.roundValue<9){
        SetCurrentQuestion();
        wordManager.instance.incementScore();
        }
        else{
            GameOver();
        }
    }

   void GameOver(){
         GameOverPanel.SetActive(true);
          
   }
    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        statementText.text = currentQuestion.statement;


        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "WRONG";

            
        }else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";

        }

    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
       

        animator.SetTrigger("True");
        if (currentQuestion.isTrue)
        { 
            Debug.Log("CORRECT!");
            ScoreScript.wscoreValue += 1;
             roundScript.roundValue += 1; 


           
    }else
        {
            Debug.Log("WRONG!");
             roundScript.roundValue += 1;
        }
                 StartCoroutine(TransitionToNextQuestion()); 
    }


    public void UserSelectFalse()
    {
        animator.SetTrigger("False");
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
            ScoreScript.wscoreValue += 1;
             roundScript.roundValue += 1;
        }
        else
        {
            Debug.Log("WRONG!");
             roundScript.roundValue += 1;
        }
        StartCoroutine(TransitionToNextQuestion());

    }

}

