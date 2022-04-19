using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruccionEnemigos_F3 : MonoBehaviour
{
    public Image BarraVida;
    public Image Vida;
    public Image BackgroundNegro;
    public Image BackgroundRojo;
    public ParticleSystem explosion;
    public float vidaExplosion;
    //public float vidaExplosion;
    // Start is called before the first frame update
    public int puntuacion = 20;

    public float vida = 500;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 500);
        Vida.fillAmount = vida / 500;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rayo")
        {
            Score_F3.score += puntuacion;
            Instantiate(explosion, transform.position, transform.rotation);
            vida -= 50;
        }
            if (vida == 0)
            {
                Destroy(this.gameObject);
                Destroy(BarraVida);
                Destroy(Vida);
                Destroy(BackgroundNegro);
                Destroy(BackgroundRojo);
            }
        
    }
   
    /*
     * private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
    */
}
