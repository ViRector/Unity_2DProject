using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Life : MonoBehaviour
{
    public int EnemyScore;
    public int vida;
    public int vidaMax;

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
            GameManager.Instance.enemy1++;
            GameManager.Instance.enemiesDestroyed++;
            GameManager.Instance.ED_SFX = true;
            //EnemyD_SFX.Play();
            vida = vidaMax;
            
        }
    }
}
