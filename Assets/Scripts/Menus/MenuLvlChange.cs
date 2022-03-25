using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLvlChange : MonoBehaviour
{
    public string nivel;

    public Animator transition;
    public float transitionTime = 1f;

    void start()
    {
        Debug.Log("Hola");
    }
    public void Empezar()
    {
        StartCoroutine(StartGame());
        //SceneManager.LoadScene(nivel);
        Debug.Log("uwu");
    }

    public void Salir()
    {
        StartCoroutine(Quit());
        //Application.Quit();
    }

    /*private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Empezar();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Salir();
        }
    }*/

    IEnumerator StartGame()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene("Game");
    }

    IEnumerator Quit()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        Application.Quit();
    }
}

