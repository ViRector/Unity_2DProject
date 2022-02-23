using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrops : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.Instance.currency++;
            Destroy(this.gameObject);
        }
    }

}
