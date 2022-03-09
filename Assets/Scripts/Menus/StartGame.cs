using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Empezar()
    {
        SceneManager.LoadScene("Instructions");
    }

    // Update is called once per frame
    public void Salir()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Empezar();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
    }
}
