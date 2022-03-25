using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSUI1 : MonoBehaviour
{
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = GameManager.Instance.hScores[0].ToString();
    }
}
