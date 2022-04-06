using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy3UIScore : MonoBehaviour
{
    private Text texto;

    void Start()
    {
        texto = GetComponent<Text>();
    }

    void Update()
    {
        texto.text = GameManager.Instance.enemy3.ToString();

    }
}
