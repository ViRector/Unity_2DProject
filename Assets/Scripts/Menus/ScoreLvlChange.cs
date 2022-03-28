using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLvlChange : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    public string menu;
    public string restart;

    public void Menu()
    {

        //SceneManager.LoadScene(menu);
        GameManager.Instance.vida = 5;
        GameManager.Instance.runScore = 0;
        GameManager.Instance.enemy1 = 0;
        GameManager.Instance.enemy2 = 0;
        GameManager.Instance.enemy3 = 0;
        GameManager.Instance.enemiesDestroyed = 0;
        GameManager.Instance.totalEnemyScore = 0;
        GameManager.Instance.penalty = 0;

        GameManager.Instance.SMPlay = false;
        GameManager.Instance.counterST++;
        GameManager.Instance.counterSF++;

        GameManager.Instance.MMPlay = true;
        Debug.Log("MM Start");

        StartCoroutine(Menuu());
        //LoadMenu();
    }

    public void Restart()
    {

        //SceneManager.LoadScene(restart);
        GameManager.Instance.vida = 5;
        GameManager.Instance.runScore = 0;
        GameManager.Instance.enemy1 = 0;
        GameManager.Instance.enemy2 = 0;
        GameManager.Instance.enemy3 = 0;
        GameManager.Instance.enemiesDestroyed = 0;
        GameManager.Instance.totalEnemyScore = 0;
        GameManager.Instance.penalty = 0;

        GameManager.Instance.SMPlay = false;
        GameManager.Instance.counterST++;
        GameManager.Instance.counterSF++;

        GameManager.Instance.counterT++;
        GameManager.Instance.BGPlay = true;
        Debug.Log("BGM Start");

        StartCoroutine(Restartt());
        //LoadRestart();
    }

  

    /*public void LoadMenu()
    {
        StartCoroutine(Menuu());
    }*/

    IEnumerator Menuu()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        GameManager.Instance.counterT++;
        SceneManager.LoadScene(menu);
    }

    /*public void LoadRestart()
    {
        StartCoroutine(Restartt());
    }*/

    IEnumerator Restartt()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(restart);
        
    }

    /*public void LoadMenu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(LoadLevelMenu(SceneManager.LoadScene(menu)));
    }

    IEnumerator LoadLevelMenu(string menu)
    {
        //Play Animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(menu);
    }

    ///////
    ///
    public void LoadRestart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(LoadLevelRestart(SceneManager.LoadScene(restart)));
    }

    IEnumerator LoadLevelRestart(string restart)
    {
        //Play Animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(restart);
    }*/
}
