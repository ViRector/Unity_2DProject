using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScore : MonoBehaviour
{
    public int vida;

    void Update()
    {
        if (vida <= 0)
        {
            GameManager.Instance.enemy1 ++;
            Destroy(this.gameObject);
        }  
    }
}
