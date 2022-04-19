using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionAsteroides_F3 : MonoBehaviour
{
    
    public ParticleSystem explosion;
    public float vidaExplosion;
    //public float vidaExplosion;
    // Start is called before the first frame update
    public int puntuacion = 20;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rayo")
        {
            Score_F3.score += puntuacion;
            //OnDestroy();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        else
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    /*
    private void OnDestroy()
    {
        Score_F3.score += puntuacion;
    }
    */
}
