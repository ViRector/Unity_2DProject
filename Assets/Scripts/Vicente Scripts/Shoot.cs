using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform ShootPoint;
    public Transform ProjectilePref;

    //public int Penalty;
    private int Penalty;

    // Update is called once per frame
    void Start()
    {
        Penalty = 5;
        //GameManager.Instance.penalty = Penalty;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            print("shoot");
            Instantiate(ProjectilePref, ShootPoint.position, ProjectilePref.rotation);
            GameManager.Instance.penalty -= Penalty;
            //GameManager.Instance.runScore -= GameManager.Instance.penalty;
        }
    }
}
