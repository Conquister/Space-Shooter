using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerup : MonoBehaviour
{
    
    public GameObject pickupEffect;
    public float vida;
    //public float duration = 4f;

    private void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameObject vidaEscudo = GameObject.FindGameObjectWithTag("VidaEscudo");
            VidaEscudo estadoEscudo = vidaEscudo.GetComponent<VidaEscudo>();
            vida -= 25;
            estadoEscudo.vidaText.text = "Escudo: " + vida.ToString();

            //Eliminar escudo
            if (vida == 0 )
            {
                //this.GetComponent<MeshRenderer>().enabled = false;
                //this.GetComponent<Collider>().enabled = false;
                Destroy(this.gameObject);

            }
        }

    }

}
