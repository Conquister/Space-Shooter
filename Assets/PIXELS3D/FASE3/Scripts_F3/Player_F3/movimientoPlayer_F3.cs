//  ****FUNCIONA CON EL AXIS CONTROLLER.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;


public class movimientoPlayer_F3 : MonoBehaviour
{
    private Rigidbody2D rb;

    private float dirX, dirY;
    [Range(1, 20)]
    public float moveSpeed = 1;
    public Joystick joystick;

    public GameObject disparo;              //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public Transform disparador;            //Declaro la variable de tipo Transform para la posición del disparador
    [Range(0, 20)]                           //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    public float velocidadDisparo = 0.25f;  //4 por segundo
    private float proximoDisparo;           //Tiempo que tiene que transcurrir hasta el próximo disparo


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > proximoDisparo)
        {

            //Incremento el valor de proximo disparo
            proximoDisparo = Time.time + velocidadDisparo;

            //Instancio un nuevo disparo en esa posición y con esa rotación
            Instantiate(disparo, disparador.position, disparador.rotation);
        }

        dirX = joystick.Horizontal * moveSpeed;
        dirY = joystick.Vertical * moveSpeed;
        //dirX = Input.GetAxis("Horizontal") * moveSpeed;
        //dirZ = Input.GetAxis("Vertical") * moveSpeed;


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
        //transform.position += new Vector2(dirX, dirZ) * moveSpeed * Time.deltaTime;
    }

}


   



