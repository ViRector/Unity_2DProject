using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLvlChange : MonoBehaviour
{
    public string menu;
    public string restart;

    public void Menu()
    {

        SceneManager.LoadScene(menu);
    }

    public void Restart()
    {

        SceneManager.LoadScene(restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
