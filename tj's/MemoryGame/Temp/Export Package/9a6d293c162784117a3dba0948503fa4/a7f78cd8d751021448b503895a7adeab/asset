using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour

{
    public static UIManager instance;
    public GameObject BrainBolterPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject leaderBoardButton;
    public Text score;
    public Text highscore;
    public Text highscore2;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highScore").ToString();
    }

    public void GameStart()
    {
        highscore.text = PlayerPrefs.GetInt("highScore").ToString();
        tapText.SetActive(false);
       
        BrainBolterPanel.GetComponent<Animator>().Play("TitleUp");
    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);

    }

    public void ShowLeaderBoard(){
        LeaderboardManager.instance.showBoard();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
