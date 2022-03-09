using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLvlChange : MonoBehaviour
{
    public string nivel;

    public void Empezar()
    {

        SceneManager.LoadScene(nivel);
    }

    public void Salir()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Empezar();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
    }
}

