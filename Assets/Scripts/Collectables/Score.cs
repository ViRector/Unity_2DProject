using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private int intScore;
    
    private int Penalty;

    // Update is called once per frame
    void Update()
    {
        Penalty = GameManager.Instance.penalty;

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 4 * Time.deltaTime;
            ///score -= Penalty;
            scoreText.text = ((int)score).ToString();
            //scoreText.text = GameManager.Instance.score.ToString();
            intScore = Mathf.RoundToInt(score);
            

            GameManager.Instance.runScore = intScore;
        }
        
        /*
         * Switch (killScore)
         * case Enemy1:
         * score + 10;
         * break;
         * 
         * case Enemy2:
         * score + 25;
         * break;
         * 
         * case Enemy3:
         * score + 50;
         * break;                          
        */
    }
}
