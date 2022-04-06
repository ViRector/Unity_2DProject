using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform ShootPoint;
    public Transform ProjectilePref;

    public int Penalty;

    [SerializeField] private AudioSource ShootSFX;

    // Update is called once per frame
    void Start()
    {
        //GameManager.Instance.penalty = Penalty;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Shot");
            ShootSFX.Play();
            Instantiate(ProjectilePref, ShootPoint.position, ProjectilePref.rotation);
            GameManager.Instance.penalty -= Penalty;
            //GameManager.Instance.runScore -= GameManager.Instance.penalty;
        }
    }
}
