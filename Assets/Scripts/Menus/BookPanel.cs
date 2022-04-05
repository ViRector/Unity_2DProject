using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPanel : MonoBehaviour
{
    [SerializeField] GameObject Panel;
   
    public void ShowBook()
    {
        Panel.SetActive(true);
    }

    public void QuitBook()
    {
        Panel.SetActive(false);
    }
}
