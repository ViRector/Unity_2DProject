using UnityEngine;

public class DeathZone : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameManager.Instance.vida = 0;
        }
    }
}
