using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using System.Xml;


public class ScoreData
{
    public int highScore;

    public ScoreData() { }
    public ScoreData(int score)
    {
        highScore = score;
    }
}

public static class XML_save
{
    public static int score;
    public static int previousHScore;


    public static void Start()
    {
        if (!File.Exists(Application.persistentDataPath + "/Resources/" + "HighScore.xml"))
        {
            CreateFile();
        }
        

    }

    public static void Update()
    {

    }

    public static void SaveScore()
    {
        var data = new ScoreData();

            int score = Score_F3.score;
            if (score > previousHScore)
            {
                data.highScore = score;
                XmlSerializer slr = new XmlSerializer(typeof(ScoreData));
                FileStream streamFile = File.Create(Application.persistentDataPath + "/Resources/" + "HighScore.xml");
                slr.Serialize(streamFile, data);
                streamFile.Close();

            }
    }
    

    public static int LoadScore()
    {
        var data = new ScoreData();

        if (File.Exists(Application.persistentDataPath + "/Resources/" + "HighScore.xml"))
        {
            XmlSerializer slr = new XmlSerializer(typeof(ScoreData));
            FileStream streamFile = File.Open(Application.persistentDataPath + "/Resources/" + "HighScore.xml", FileMode.Open);
            data = slr.Deserialize(streamFile) as ScoreData;

            streamFile.Close();
            previousHScore = data.highScore;
        }

        if (File.Exists(Application.persistentDataPath + "/Resources/" + "HighScore.xml"))
        {
            XmlSerializer slr = new XmlSerializer(typeof(ScoreData));
            FileStream streamFile = File.Open(Application.persistentDataPath + "/Resources/" + "HighScore.xml", FileMode.Open);
            data = slr.Deserialize(streamFile) as ScoreData;

            streamFile.Close();
            previousHScore = data.highScore;
        }

        return previousHScore;

    }

    private static void CreateFile(string fileName = "HighScore.xml")
    {
        if (!Directory.Exists(Application.persistentDataPath + "/Resources/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Resources/");
        }

        if (!File.Exists(Application.persistentDataPath + "/Resources/" + fileName))
        {
            var f = File.Create(Application.persistentDataPath + "/Resources/" + fileName);
            f.Close();
        }

    }


}
