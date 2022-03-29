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
            
            
            LoadNextLevel();
        }
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
