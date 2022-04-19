using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Destruccion : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject GameOverUI;
    public ParticleSystem explosion;
    private float tiempo = 2f;

    private bool tienePowerup = false;
    public GameObject indicadorPowerUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Escudo" || other.gameObject.tag == "Player")
        {
            return;
        }
        else if(other.CompareTag("CapsulePowerUp"))
        {
                tienePowerup = true;
                indicadorPowerUp.gameObject.SetActive(true);
                Destroy(other.gameObject);

        }
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
