using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy3MultipliedScore : MonoBehaviour
{
    private Text texto;
    public int points;
    private int kills;
    private int total;

    void Start()
    {
        texto = GetComponent<Text>();

        kills = GameManager.Instance.enemy3;

        total = kills * points;

        GameManager.Instance.totalEnemyScore += total;
    }

    void Update()
    {
        texto.text = total.ToString();

    }
}
