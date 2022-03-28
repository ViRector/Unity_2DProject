using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music Instance;

    [SerializeField] private AudioSource BGMusic, MenuMusic, ScoreMusic;

    
   

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        //SingleTone
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameManager.Instance.BGPlay == true)
        {
            PlayingBGM();
        }*/

        if (GameManager.Instance.MMPlay == true && GameManager.Instance.counterMT > 0)
        {
            PlayingMM();
            GameManager.Instance.counterMT--;
        }

        if (GameManager.Instance.BGPlay == true && GameManager.Instance.counterT > 0)
        {
            PlayingBGM();
            StopMenuMusic();
            GameManager.Instance.counterT--;
        }

        if (GameManager.Instance.BGPlay == false && GameManager.Instance.counterF > 0)
        {
            StopBGM();
            GameManager.Instance.counterF--;
            Debug.Log("Called Void StopBGM");
        }

        if (GameManager.Instance.SMPlay == true && GameManager.Instance.counterST > 0)
        {
            PlayingSM();
            GameManager.Instance.counterST--;
        }

        if (GameManager.Instance.SMPlay == false && GameManager.Instance.counterSF > 0)
        {
            StopSM();
            GameManager.Instance.counterSF--;
        }

    }

    public void PlayingBGM()
    {
        BGMusic.Play();
        Debug.Log("BM Playing");
    }

    public void StopBGM()
    {
        BGMusic.Stop();
        Debug.Log("BM Stopped");
    }

    public void StopMenuMusic()
    {
        MenuMusic.Stop();
        Debug.Log("MM Stop");
    }

    public void PlayingMM()
    {
        MenuMusic.Play();
        Debug.Log("MM Play");
    }

    public void PlayingSM()
    {
        ScoreMusic.Play();
        Debug.Log("SM Play");
    }
    public void StopSM()
    {
        ScoreMusic.Stop();
        Debug.Log("SM Stop");
    }

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    /*
    public int counterMT = 1;
    public int counterMF = 1;

    public int counterST = 1;
    public int counterSF = 1;
     
     */
}
