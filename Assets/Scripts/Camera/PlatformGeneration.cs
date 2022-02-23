using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWitdh;


    // Start is called before the first frame update
    void Start()
    {
        platformWitdh = thePlatform.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWitdh + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(thePlatform, transform.position, transform.rotation);
        }
    }
}
