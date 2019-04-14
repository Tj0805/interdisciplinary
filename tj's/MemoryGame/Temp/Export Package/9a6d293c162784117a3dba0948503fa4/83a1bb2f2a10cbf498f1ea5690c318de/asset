using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    private bool gameEnded = false;

    public Circle circle;
    public Spawner spawner; 
    public Animator animator;


        

    public void GameOver()
    {
        if (gameEnded)
            return;

        circle.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGami");
        
        gameEnded = true;
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
