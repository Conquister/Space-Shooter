using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDesaparicion_F3 : MonoBehaviour
{
	
	private float vidaExplosion = 1;       //Declaro la varia pública para poder modificar la vida del Disparo (en segundos)

	void Start()
	{
		
	}


	private void Update()
	{
		Destroy(gameObject, vidaExplosion);
	}


}
