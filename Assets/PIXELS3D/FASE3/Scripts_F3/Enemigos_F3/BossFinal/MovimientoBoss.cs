using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBoss : MonoBehaviour
{
    [Header("Movimiento")]
    //private Transform rb;
    private float velocidadX = 1;
    private float velocidadY = -2.5f;
    
    [Header("Disparo")]
    public GameObject disparo;              //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public GameObject explosion;
    public Transform disparador;            //Declaro la variable de tipo Transform para la posici�n del disparador
    [Range(0, 20)]                           //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    public float velocidadDisparo = 0.25f;  //4 por segundo
    private float proximoDisparo;           //Tiempo que tiene que transcurrir hasta el pr�ximo disparo


    void Start()
    {
        //rb = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, 0, velocidadY * Time.deltaTime);
        if ((transform.position.x < -6) || (transform.position.x > 6))
        {
            //transform.position.z = -2;
            velocidadX = -velocidadX;
        }
        if ((transform.position.y < 22.50) || (transform.position.y > 30))
        {
            //transform.position.z = -2;
            velocidadY = -velocidadY;
        }

        if (Time.time > proximoDisparo)
        {

            //Incremento el valor de proximo disparo
            proximoDisparo = Time.time + velocidadDisparo;
            
            //Instancio un nuevo disparo en esa posici�n y con esa rotaci�n
            Instantiate(disparo, disparador.position, disparador.rotation);
            //Instantiate(disparo, disparador.position, Quaternion.identity);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Rayo")){
        Instantiate(explosion, transform.position, transform.rotation);
       }
      //  Destroy(this.gameObject);
    }
}