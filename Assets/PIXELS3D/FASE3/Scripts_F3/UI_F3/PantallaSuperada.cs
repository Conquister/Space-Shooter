using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaSuperada : MonoBehaviour
{
    public void FinalBoss()
    {
        SceneManager.LoadScene(4);
        Resume();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
