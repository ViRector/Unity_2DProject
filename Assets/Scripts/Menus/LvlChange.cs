using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
    public string nivel;

    void Update()
    {
        if (GameManager.Instance.vida <= 0)
        {                                                                                                                                                                                        
            SceneManager.LoadScene(nivel);
        }
    }

}
