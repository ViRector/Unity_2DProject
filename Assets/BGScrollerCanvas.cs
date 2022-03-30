using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrollerCanvas : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 startPosition;
    private Vector3 topPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        //topPosition += Vector3(0, 10, 0);    //(transform.position.x, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            //transform.position = startPosition;
            //transform.position = topPosition;
            transform.position += new Vector3(0, 403, 0);
        }


        /*transform.position += new Vector3(-5 * Time.deltaTime, 0);

        if (transform.position.x < -21.5)
        {
            transform.position = new vector3(21.5f, transform.position.y);
        }*/
    }
}
