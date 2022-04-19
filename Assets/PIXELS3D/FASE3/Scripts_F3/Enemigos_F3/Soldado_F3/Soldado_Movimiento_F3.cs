using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldado_Movimiento_F3 : MonoBehaviour
{
    [Header("Movimiento")]
    //private Transform rb;
    private float velocidadX = 1;
    private float velocidadY = -2.5f;
    
    [Header("Disparo")]
    public GameObject disparo;              //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public Transform disparador;            //Declaro la variable de tipo Transform para la posición del disparador
    [Range(0, 20)]                           //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    public float velocidadDisparo = 0.25f;  //4 por segundo
    private float proximoDisparo;           //Tiempo que tiene que transcurrir hasta el próximo disparo


    void Start()
    {
        //rb = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, 0, velocidadY * Time.deltaTime);
        if ((transform.position.x < -5.5) || (transform.position.x > 5.5))
        {
            velocidadX = -velocidadX;
        }
        if ((transform.position.y < 12.5) || (transform.position.y > 25))
        {
            velocidadY = -velocidadY;
        }

        if (Time.time > proximoDisparo)
        {

            //Incremento el valor de proximo disparo
            proximoDisparo = Time.time + velocidadDisparo;

            //Instancio un nuevo disparo en esa posición y con esa rotación
            Instantiate(disparo, disparador.position, disparador.rotation);
        }



        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        //transform.position = new Vector2(xRandom * Time.deltaTime, yRandom * Time.deltaTime);


    }
}