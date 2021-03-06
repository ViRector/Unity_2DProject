using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Life : MonoBehaviour
{
    public int EnemyScore;
    public int vida;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            vida -= 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player")
        {
            GameManager.Instance.vida -= 1;
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (vida <= 0)
        {
            this.gameObject.SetActive(false);
            GameManager.Instance.enemy3++;
            GameManager.Instance.enemiesDestroyed++;
        }
    }
}
