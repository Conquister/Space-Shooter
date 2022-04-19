using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPowerUp_VelocidadDisparos : MonoBehaviour
{
    public movimientoPlayer3D_F3 Player;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<movimientoPlayer3D_F3>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "RayoBoss")
        { 
            gameObject.SetActive(false);
        Player.velocidadDisparo = 0.25f;
            //Destroy(this.gameObject);
        }
    }
}
