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

    public float totalScore;

    public int enemy1MScore;
    public int enemy2MScore;
    //
    //High Score
    //public float highScore;
    public float[] hScores;
    //
    //Music
    public bool BGPlay = false;
    //private AudioSource BGMusic;

    public int counterT = 1;
    public int counterF = 1;

    public bool MMPlay = true;
    public int counterMT = 1;
    public int counterMF = 1;

    public bool SMPlay = false;
    public int counterST = 1;
    public int counterSF = 1;

    //
    //SFX
    public bool ED_SFX = false;
    public bool GameOver_SFX = false;
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
        hScores[0] = 860;
        hScores[1] = 640;
        hScores[2] = 420;
        hScores[3] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (BGPlay == true)
        //BGMusic.Play();
    }
}
