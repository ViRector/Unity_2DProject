using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    private Text texto;
    private float total;

    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.1f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;

    string writer;

    void Start()
    {
        texto = GetComponent<Text>();
        ScoresCount();
    }

    /*void Update()
    {
        print("2 = " + GameManager.Instance.enemy2MScore);
        //texto.text = total.ToString();

    }*/


    private void ScoresCount()
    {
        //yield return new WaitForSeconds(1f);
        //----total = GameManager.Instance.totalEnemyScore + GameManager.Instance.runScore;
        //print("Enemy Score = " + GameManager.Instance.totalEnemyScore);
        //print("Enemy Score = " + GameManager.Instance.totalEnemyScore);
        //print("Enemy Score = " + GameManager.Instance.totalEnemyScore);
        //print("Run Score = " + GameManager.Instance.runScore);
        //print("Total Score = " + (GameManager.Instance.totalEnemyScore + GameManager.Instance.runScore));

        //----GameManager.Instance.totalScore = total;

        total = GameManager.Instance.enemy1MScore + GameManager.Instance.enemy2MScore + GameManager.Instance.runScore;
        print("Total = " + (GameManager.Instance.enemy1MScore + GameManager.Instance.enemy2MScore + GameManager.Instance.runScore));
        print("2 = " + GameManager.Instance.enemy2MScore);


        GameManager.Instance.totalScore = total;


        texto.text = GameManager.Instance.totalScore.ToString();

        //if (total > GameManager.Instance.highScore)
        //GameManager.Instance.highScore = total;
        //
        if (total > GameManager.Instance.hScores[3] && total < GameManager.Instance.hScores[2])
        {
            GameManager.Instance.hScores[3] = total;
            Debug.Log("caso 1");
        }

        else if (total > GameManager.Instance.hScores[2] && total < GameManager.Instance.hScores[1])
        {
            GameManager.Instance.hScores[3] = GameManager.Instance.hScores[2];
            GameManager.Instance.hScores[2] = total;
            Debug.Log("caso 2");
        }

        else if (total > GameManager.Instance.hScores[1] && total < GameManager.Instance.hScores[0])
        {
            GameManager.Instance.hScores[3] = GameManager.Instance.hScores[2];
            GameManager.Instance.hScores[2] = GameManager.Instance.hScores[1];
            GameManager.Instance.hScores[1] = total;
            Debug.Log("caso 3");
        }

        else if (total > GameManager.Instance.hScores[0]) // || < GameManager.Instance.hScores[0])
        {
            GameManager.Instance.hScores[3] = GameManager.Instance.hScores[2];
            GameManager.Instance.hScores[2] = GameManager.Instance.hScores[1];
            GameManager.Instance.hScores[1] = GameManager.Instance.hScores[0];
            GameManager.Instance.hScores[0] = total;
            Debug.Log("caso 4");
        }


        //


        if (texto.text != null)
        {
            writer = texto.text;
            texto.text = "";

            StartCoroutine("TypeWriterText");
        }
    }

    IEnumerator TypeWriterText()
    {
        texto.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

        foreach (char c in writer)
        {
            if (texto.text.Length > 0)
            {
                texto.text = texto.text.Substring(0, texto.text.Length - leadingChar.Length);
            }
            texto.text += c;
            texto.text += leadingChar;
            yield return new WaitForSeconds(timeBtwChars);
        }

        if (leadingChar != "")
        {
            texto.text = texto.text.Substring(0, texto.text.Length - leadingChar.Length);
        }
    }
}
