using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music Instance;

    [SerializeField] private AudioSource BGMusic;

    
   

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

        if (GameManager.Instance.BGPlay == true && GameManager.Instance.counterT > 0)
        {
            PlayingBGM();
            GameManager.Instance.counterT--;
        }

        if (GameManager.Instance.BGPlay == false && GameManager.Instance.counterF > 0)
        {
            StopBGM();
            GameManager.Instance.counterF--;
            Debug.Log("Called Void StopBGM");
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

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }
}
