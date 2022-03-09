using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    private Text texto;
    private float total;

    void Start()
    {
        texto = GetComponent<Text>();
        total += GameManager.Instance.totalEnemyScore + GameManager.Instance.runScore;
    }

    void Update()
    {
        texto.text = total.ToString();

    }
}
