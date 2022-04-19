using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionGameOver : MonoBehaviour
{
    public string scoreString = "Puntuacion:";

    public Text textScore;

    private static int scored;

    private void Awake()
    {
        scored = Score_F3.score;
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
