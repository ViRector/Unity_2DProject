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

    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.1f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;

    string writer;

    void Start()
    {
        texto = GetComponent<Text>();

        kills = GameManager.Instance.enemy3;

        total = kills * points;

        GameManager.Instance.totalEnemyScore += total;
        texto.text = total.ToString();

        if (texto.text != null)
        {
            writer = texto.text;
            texto.text = "";

            StartCoroutine("TypeWriterText");
        }
    }

    void Update()
    {
        //texto.text = total.ToString();

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
