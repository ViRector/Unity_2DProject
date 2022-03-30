using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string nivel;
    [SerializeField] private AudioSource DeathSFX;

    void Update()
    {
        if (GameManager.Instance.vida <= 0)
        {
            //SceneManager.LoadScene(nivel);
            GameManager.Instance.GameOver_SFX = true;
            //DeathSFX.Play();
            GameManager.Instance.counterF++;
            GameManager.Instance.BGPlay = false;
            Debug.Log("BGM False");


            //
            //SoundEffects.PlaySound("Death");
            //

            ScoreCount();
            LoadNextLevel();

        }
    }


    public int points;
    private int kills;
    private int total;

    public int points2;
    private int kills2;
    private int total2;

    public void ScoreCount()
    {

        kills = GameManager.Instance.enemy1;
        total = kills * points;
        GameManager.Instance.enemy1MScore = total;
        Debug.Log("1 = " + GameManager.Instance.enemy1MScore);

        kills2 = GameManager.Instance.enemy2;
        total2 = kills2 * points2;
        GameManager.Instance.enemy2MScore = total2;
        Debug.Log("Kills/GameManager.Instance.enemy2 = " + GameManager.Instance.enemy2);
        Debug.Log("points = " + points2);
        Debug.Log("2 = " + GameManager.Instance.enemy2MScore);

    }

    public void LoadNextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        StartCoroutine(ToScore());
    }

    /*IEnumerator LoadLevel(int levelIndex)
    {
        //Play Animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }*/
    IEnumerator ToScore()
    {
        //Play Animation
        GameManager.Instance.SMPlay = true;
        Debug.Log("SM True");

        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        
        Debug.Log("Load Score Scene");
        SceneManager.LoadScene(nivel);

        


    }
}
