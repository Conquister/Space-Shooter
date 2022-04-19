using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PantallaSuperadaUI;
    public float tiempo = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Temp());
    }

    IEnumerator Temp()
    {
        yield return new WaitForSeconds(tiempo);
        PantallaSuperada();
    }

    public void PantallaSuperada()
    {
        PantallaSuperadaUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
