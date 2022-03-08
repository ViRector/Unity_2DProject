using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform ShootPoint;
    public Transform ProjectilePref;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePref, ShootPoint.position, ProjectilePref.rotation);
        }
    }
}
