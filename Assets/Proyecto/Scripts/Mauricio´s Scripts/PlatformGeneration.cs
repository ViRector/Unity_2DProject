using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWitdh;

    public float DistanceBetweenMin;
    public float DistanceBetweenMax;

    //public GameObject[] thePlatforms; 
    private int platformSelector;
    private float[] platformWidths;


    public ObjectPooler[] theObjectPools;

    // Start is called before the first frame update
    void Start()
    {
        // platformWitdh = thePlatform.GetComponent<BoxCollider2D>().size.x;
        platformWidths = new float[theObjectPools.Length];

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }


    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(DistanceBetweenMin, DistanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);

            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector / 2] + distanceBetween, transform.position.y, transform.position.z);





            //Instantiate(/* thePlatform */ thePlatforms[platformSelector] , transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;

            newPlatform.transform.rotation = transform.rotation;

            newPlatform.SetActive(true);



            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector / 2], transform.position.y, transform.position.z);

        }
    }
}
