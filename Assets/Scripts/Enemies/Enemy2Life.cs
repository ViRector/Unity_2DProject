using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Life : MonoBehaviour
{
    public int EnemyScore;
    public int vida;

    [SerializeField] private AudioSource EnemyD_SFX;

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
            GameManager.Instance.enemy2++;
            GameManager.Instance.enemiesDestroyed++;
            GameManager.Instance.ED_SFX = true;
            //EnemyD_SFX.Play();
        }
    }
}
