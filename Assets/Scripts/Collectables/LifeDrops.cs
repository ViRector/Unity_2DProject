using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDrops : MonoBehaviour
{
    public Animator PlayerAnimator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerAnimator.SetTrigger("Heal");
            GameManager.Instance.vida ++;
            Destroy(this.gameObject);
        }
    }

}
