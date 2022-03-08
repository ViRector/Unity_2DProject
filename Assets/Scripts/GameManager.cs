using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public int score; No se si me servirá después uwu
    // Start is called before the first frame update
    public static GameManager Instance;

    public int vida;
    public int currency;
    //Score
    public float runScore;
    public int enemy1;
    public int enemy2;
    public int enemy3;
    public int enemiesDestroyed;
    public int totalEnemyScore;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
