using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunScore : MonoBehaviour
{
    private Text texto;

	/*void Start()
    {
        texto = GetComponent<Text>();
    }

    void Update()
    {
        texto.text = GameManager.Instance.runScore.ToString();

    }*/

	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;

	string writer;

	void Start()
	{
		texto = GetComponent<Text>();
		texto.text = GameManager.Instance.runScore.ToString();

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
