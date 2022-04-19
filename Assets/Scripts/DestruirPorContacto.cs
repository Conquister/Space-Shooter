using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorContacto : MonoBehaviour{

public GameObject explosion;
public GameObject playerExplosion;

private GameController gamecontroller;
public int PuntosPorAsteroide;

    void Start(){
        //gamecontroller = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

   void OnTriggerEnter(Collider otro){
       //Debug.Log(otro.name);
       //if (otro.tag == "Limite") return;
       if (otro.CompareTag("Limite")) return;
        Instantiate(explosion, transform.position, transform.rotation);
       if (otro.CompareTag("Player")){
           Instantiate(playerExplosion, otro.transform.position, otro.transform.rotation);
           gamecontroller.GameOver();
       }
       
        gamecontroller.AddScore(PuntosPorAsteroide);

        if (!otro.CompareTag("Escudo"))
        {
            Destroy(otro.gameObject);
        }
        Destroy(gameObject);
   }
}
