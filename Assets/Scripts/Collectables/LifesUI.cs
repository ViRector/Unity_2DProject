using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifesUI : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < GameManager.Instance.vida; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }

        for (int i = GameManager.Instance.vida; i < 5; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}