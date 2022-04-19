//  ****FUNCIONA CON EL AXIS CONTROLLER.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;


public class movimientoPlayer3D_F3 : MonoBehaviour
{

    //Player_Movimiento
    [Header("Movimiento")]
    private Rigidbody rb;
    private float dirX, dirY;
    [Range(1, 20)]
    public float moveSpeed = 1;
    public Joystick joystick;
    private float limiteX = 5f;
    private float limiteY = 15f;
    public float inclinacion;

    //Player_Disparos
    [Header("Disparos")]
    public GameObject disparo;              //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public Transform disparador;            //Declaro la variable de tipo Transform para la posición del disparador
    [Range(0, 20)]                           //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    public float velocidadDisparo = 0.25f;  //4 por segundo
    private float proximoDisparo;           //Tiempo que tiene que transcurrir hasta el próximo disparo


    //Player_Destruccion
    [Header("Destrucción")]
    public static bool GameIsPaused = false;
    public GameObject GameOverUI;
    public ParticleSystem explosion;
    private float tiempo = 2f;


    //Player_PowerUP
    [Header("PowerUP")]
    private bool tienePowerupVelocidad = false;
    public GameObject PowerUP_EscudoF3;
    public GameObject PowerUP_VelocidadDisparo_F3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //moveSpeed = 5f;
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

        

        if(transform.position.x < -limiteX)
        {
            transform.position = new Vector3(-limiteX, transform.position.y, transform.position.z);
        }

        if(transform.position.x > limiteX)
        {
            transform.position = new Vector3(limiteX, transform.position.y, transform.position.z);
        }

        PowerUP_EscudoF3.transform.position = transform.position - new Vector3(0, 0.5f, 0);
        PowerUP_VelocidadDisparo_F3.transform.position = transform.position - new Vector3(0, 0.5f, 0);
        
        if (transform.position.y < -limiteY + 18f)
        {
            transform.position = new Vector3(transform.position.x , -limiteY + 18f, transform.position.z);
        }

        if (transform.position.y > limiteY)
        {
            transform.position = new Vector3(transform.position.x, limiteY, transform.position.z);
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
        rb.rotation = Quaternion.Euler(-90f, 0f, rb.velocity.x * -inclinacion);
        //PowerUP_EscudoF3.transform.position = transform.position;
        //transform.position += new Vector2(dirX, dirZ) * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Escudo")
        {
            return;
        }
        else if (other.CompareTag("CapsulePowerUp"))
        {

            PowerUP_EscudoF3.gameObject.SetActive(true);
            //Instantiate(PowerUP_EscudoF3, transform.position, transform.rotation);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CapsulePowerUp2"))
        {
            //tienePowerupVelocidad = true;
            PowerUP_VelocidadDisparo_F3.gameObject.SetActive(true);
            velocidadDisparo = 0.05f;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Enemy") || other.CompareTag("RayoBoss"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}



   



