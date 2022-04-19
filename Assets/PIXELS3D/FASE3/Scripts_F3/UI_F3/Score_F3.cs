using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_F3 : MonoBehaviour
{
    public static int score;
    public string scoreString = "Score";

    public Text textScore;

    public static Score_F3 scored;

    private void Awake()
    {
        scored = this;
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
            textScore.text = scoreString + " " + score.ToString();
        }
    }
}
