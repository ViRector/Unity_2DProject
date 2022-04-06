using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool bookQ = false;

    // Update is called once per frame
    void Update()
    {
        if (bookQ == true)
            BookOff();
    }

    public void BookOn()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void Quit()
    {
        bookQ = true;
    }

    public void BookOff()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    
}
