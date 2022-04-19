using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soldado_Destruccion_F3 : MonoBehaviour
{
    public int puntuacion = 20;
    public ParticleSystem explosion;
    // Start is called before the first frame update




    void Update()
    {

    }

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
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    /*
    private void OnDestroy()
    {
        Score_F3.score += puntuacion;
    }

    /*
     * private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
    */
}
