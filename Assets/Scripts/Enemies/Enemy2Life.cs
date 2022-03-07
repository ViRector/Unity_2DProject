using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Life : MonoBehaviour
{
    public int vida;

    void Update()
    {
        if (vida <= 0)
        {
            GameManager.Instance.enemy2++;
            Destroy(this.gameObject);
        }
    }
}
