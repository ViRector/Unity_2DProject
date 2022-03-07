using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Life : MonoBehaviour
{
    public int vida;

    void Update()
    {
        if (vida <= 0)
        {
            GameManager.Instance.enemy3++;
            Destroy(this.gameObject);
        }
    }
}
