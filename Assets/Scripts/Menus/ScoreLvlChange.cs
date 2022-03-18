using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLvlChange : MonoBehaviour
{
    public string menu;
    public string restart;

    public void Menu()
    {

        SceneManager.LoadScene(menu);
        GameManager.Instance.vida = 5;
        GameManager.Instance.runScore = 0;
        GameManager.Instance.enemy1 = 0;
        GameManager.Instance.enemy2 = 0;
        GameManager.Instance.enemy3 = 0;
        GameManager.Instance.enemiesDestroyed = 0;
        GameManager.Instance.totalEnemyScore = 0;
        GameManager.Instance.penalty = 0;
    }

    public void Restart()
    {

        SceneManager.LoadScene(restart);
        GameManager.Instance.vida = 5;
        GameManager.Instance.runScore = 0;
        GameManager.Instance.enemy1 = 0;
        GameManager.Instance.enemy2 = 0;
        GameManager.Instance.enemy3 = 0;
        GameManager.Instance.enemiesDestroyed = 0;
        GameManager.Instance.totalEnemyScore = 0;
        GameManager.Instance.penalty = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
