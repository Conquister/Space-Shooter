using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador_F3 : MonoBehaviour
{
    public Text tiempoText;
    public float tiempo = 60.0f;
    public string scoreString = "Tiempo";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;
        tiempoText.text = scoreString + tiempo.ToString("f0");
    }
}
