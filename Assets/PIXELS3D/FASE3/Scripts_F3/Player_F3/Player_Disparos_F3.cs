using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Disparos_F3 : MonoBehaviour
{
	private Rigidbody rb;           //Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro objeto
	[Range(10, 30)]                  //Declaro la variable pública velocidad para poder modificarla desde la Inspector window
	public float velocidad = 10;
	public float vidaDisparo;		//Declaro la varia pública para poder modificar la vida del Disparo (en segundos)

	void Start()
	{
		rb = GetComponent<Rigidbody>();             //Capturo el rigidbody del jugador al iniciar el juego
		rb.velocity = transform.up * velocidad;     //Aplico movimiento en dirección 'y' positiva (con su velocidad)
	}


    private void Update()
    {
		Destroy(gameObject, vidaDisparo);
    }

	private void OnTriggerEnter(Collider other)
	{
			Destroy(this.gameObject);
	}


}