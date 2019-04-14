using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wordUI : MonoBehaviour

{
    public static wordUI instance;

    public Text wscore;
    public Text whighscore;
    
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
        whighscore.text = "Highscore: " + PlayerPrefs.GetInt("whighScore").ToString();
       
    }

   

    // Update is called once per frame
    void Update()
    {
        wscore.text = PlayerPrefs.GetInt("wscore").ToString(); 
    }
}
