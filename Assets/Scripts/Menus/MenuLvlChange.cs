using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLvlChange : MonoBehaviour
{
    public string nivel;

    public Animator transition;
    public float transitionTime = 1f;

    [SerializeField] private AudioSource BGMusic;

    void start()
    {
        Debug.Log("Hola");
    }
    public void Empezar()
    {

        GameManager.Instance.BGPlay = true;
        Debug.Log("BGP true");

        StartCoroutine(StartGame());
        //SceneManager.LoadScene(nivel);
        Debug.Log("Start Game Scene");
      
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

