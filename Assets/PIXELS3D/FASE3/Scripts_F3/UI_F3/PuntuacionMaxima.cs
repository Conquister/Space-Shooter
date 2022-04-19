using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionMaxima : MonoBehaviour
{
    public string scoreString = "Puntuacion Maxima:";

    public Text textScore;

    private static int scored;

    private void Awake()
    {
        scored = XML_save.LoadScore();
        //XML_save.LoadScore();
        //        scored = XML_save.LoadScore();
        //scored = XML_save.previousHScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textScore != null)
        {
            
            textScore.text = scoreString + " " + scored.ToString();
        }
        
    }
}
