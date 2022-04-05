using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestruction : MonoBehaviour
{
    public Enemy2Life reinicioVida;
    public GameObject EnemyDestructionPoint;

    // Start is called before the first frame update
    void Start()
    {

        EnemyDestructionPoint = GameObject.Find("EnemyDestructionPoint");


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < EnemyDestructionPoint.transform.position.x)
        {
            //Destroy(gameObject);

            reinicioVida = FindObjectOfType<Enemy2Life>();
            reinicioVida.vida = reinicioVida.vidaMax;
            gameObject.SetActive(false);
            
            
        }
    }
}
