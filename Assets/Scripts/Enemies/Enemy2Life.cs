using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Life : MonoBehaviour
{
    public int EnemyScore;
    public int vida ;
    public int vidaMax;

    private Animator myAnimator;
    public Animator itsAnimator;

    [SerializeField] private AudioSource EnemyD_SFX;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            myAnimator.SetTrigger("Damage");
            vida -= 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player")
        {
            itsAnimator.SetTrigger("Damage");
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
            vida = vidaMax;
        }       
    }
}
