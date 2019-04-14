using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public static int wscoreValue = 0;
	Text wscore;
    // Start is called before the first frame update
    void Start()
    {
       wscore = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
       wscore.text = wscoreValue +"/"; 
    }
}
