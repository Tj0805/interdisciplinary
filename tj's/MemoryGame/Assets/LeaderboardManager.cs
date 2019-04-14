using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class LeaderboardManager : MonoBehaviour
{

	public static LeaderboardManager instance;

	void Awake(){
		if(instance == null ){
			instance = this; 
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        PlayGamesPlatform.Activate();
        Login();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login(){
    	Social.localUser.Authenticate((bool success) => {
    		    		});
    }

    public void addScore(){

    Social.ReportScore(ScoreManager.instance.score, ObservationLeaderboard.leaderboard_best_observation_player, (bool success) => {

    	});
    }

    public void showBoard(){

    //Social.showLeaderboardUI();

    if(Social.localUser.authenticated){
          Social.ShowLeaderboardUI ();	
    }

    else{
    	Login();
    }
    
    
    }


}
