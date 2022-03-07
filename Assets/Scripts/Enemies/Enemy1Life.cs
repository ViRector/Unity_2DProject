using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Life : MonoBehaviour
{
    public int vida;

    void Update()
    {
        if (vida <= 0)
        {
            GameManager.Instance.enemy1++;
            Destroy(this.gameObject);
        }
    }
}
