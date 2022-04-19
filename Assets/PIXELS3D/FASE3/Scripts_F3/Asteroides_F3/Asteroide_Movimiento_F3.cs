using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide_Movimiento_F3 : MonoBehaviour
{
    private float velocidadX = 2;
    

    //private float velocidadY = -5f;
    //ArrayList movimientoRandom = new ArrayList { 1, 2, 3};

    void Start()
    {
        velocidadX = Random.Range(2, 8);
    }

    private void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, 0, 0);

        if ((transform.position.x < -25) || (transform.position.x > 25))
        {
            velocidadX = -velocidadX;
        }

        /*if ((transform.position.y < -50) || (transform.position.y > 50))
        {
            velocidadY = -velocidadY;
        }
        */



        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        //transform.position = new Vector2(xRandom * Time.deltaTime, yRandom * Time.deltaTime);

    }

}



//MOVIMIENTO ASTEROIDES RANDOM
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide_Movimiento : MonoBehaviour
{
    private float xRandom;
    private float yRandom;

    //ArrayList movimientoRandom = new ArrayList { 1, 2, 3};
    void Start()
    {
        xRandom = Random.Range(-3, 4);
        yRandom = Random.Range(-3, 4);
    }

    private void Update()
    {
        transform.position += new Vector3(xRandom * Time.deltaTime, yRandom * Time.deltaTime, 0);
    }
}
*/