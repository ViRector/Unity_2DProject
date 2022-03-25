using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    public static GameManager Instance;

    public int vida;
    public int currency;
    //Score
    public float runScore;
    public int penalty;
    public int enemy1;
    public int enemy2;
    public int enemy3;
    public int enemiesDestroyed;
    public int totalEnemyScore;
    //
    //High Score
    public float highScore;

    public float[] hScores;



    //
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //SingleTone
    }

    void Start()
    {
        hScores[0] = 60;
        hScores[1] = 40;
        hScores[2] = 20;
        hScores[3] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
