using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorNivel : MonoBehaviour
{
    public void Pantalla_menuPrincipal()
    {
        SceneManager.LoadScene(0);
        Resume();
        Score_F3.score = 0;
    }
    public void Pantalla1()
    {
        SceneManager.LoadScene(1);
        Resume();
    }

    public void Pantalla2()
    {
        SceneManager.LoadScene(2);
        Resume();
    }

    public void Pantalla3()
    {
        SceneManager.LoadScene(3);
        Resume();
    }

    public void FinalBoss()
    {
        SceneManager.LoadScene(4);
        Resume();
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
