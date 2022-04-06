using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy2UIScoreWriter : MonoBehaviour
{
	private Text texto;

	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;

	string writer;

	void Start()
	{
		texto = GetComponent<Text>();
		texto.text = GameManager.Instance.enemy2.ToString();

		if (texto.text != null)
		{
			writer = texto.text;
			texto.text = "";

			StartCoroutine("TypeWriterText");
		}
	}

	void Update()
	{
		//texto.text = GameManager.Instance.enemy1.ToString();
		/*StartCoroutine("TypeWriterText");
		writer = texto.text;*/
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
