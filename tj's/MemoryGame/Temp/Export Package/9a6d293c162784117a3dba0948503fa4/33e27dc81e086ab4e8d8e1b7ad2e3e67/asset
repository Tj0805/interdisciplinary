using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordManager : MonoBehaviour
{

    public static wordManager instance;
    public int wscore;
    public int highScore;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
            }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void incementScore()
    {
        wscore = wscore + 1;
    }

   public void startScore()
    {
         wscore = 0;
        PlayerPrefs.SetInt("wscore", wscore);   

        }

    public void stopScore()
    {
        CancelInvoke("incementScore");
        PlayerPrefs.SetInt("wscore", wscore);

        if (PlayerPrefs.HasKey("highScore"))
        {
            if(wscore > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", wscore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highScore", wscore);
        }
    }
}
