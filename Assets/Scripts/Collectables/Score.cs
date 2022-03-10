using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private int intScore;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 4 * Time.deltaTime;
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
