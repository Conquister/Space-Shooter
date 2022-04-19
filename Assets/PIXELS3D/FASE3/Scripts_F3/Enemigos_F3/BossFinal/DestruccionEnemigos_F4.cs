using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruccionEnemigos_F4 : MonoBehaviour
{
    public GameObject JuegoSuperadoUI;
    public static bool GameIsPaused = false;
    public Image BarraVida;
    public Image Vida;
    public Image BackgroundNegro;
    public Image BackgroundRojo;
    public ParticleSystem explosion;
    private float vidaExplosion;
    //public float vidaExplosion;
    
    public float vida;
    public int puntuacion = 5000;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 5000);
        Vida.fillAmount = vida / 5000;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rayo")){
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            vida -= 50;
        }
        if (vida == 0)
        {
            Score_F3.score += puntuacion;
            Destroy(this.gameObject);
            Destroy(BarraVida);
            Destroy(Vida);
            Destroy(BackgroundNegro);
            Destroy(BackgroundRojo);
            GameComplete();
        }
    }

    public void GameComplete()
    {
        JuegoSuperadoUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    /*
     * private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
    */
}
