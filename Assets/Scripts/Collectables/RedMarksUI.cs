using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedMarksUI : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < GameManager.Instance.enemiesDestroyed; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }

        for (int i = GameManager.Instance.enemiesDestroyed; i < 10; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
