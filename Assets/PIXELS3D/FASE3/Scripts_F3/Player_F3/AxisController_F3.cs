using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisController_F3 : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header ("Movimiento")]
    public float speed;
    Vector3 input;
    public float shipAngle;
    float shipAngle2;
    public Joystick joystick;
    public float rotationInterpolation = 0.4f;
    //public float velocidadRotacionHorizontal;
    //public float velocidadRotacionVertical;

    [Header("Shooting")]

    
    public GameObject disparo;              //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public Transform disparador;            //Declaro la variable de tipo Transform para la posición del disparador
    [Range(0, 20)]                           //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    public float velocidadDisparo = 0.25f;  //4 por segundo
    private float proximoDisparo;           //Tiempo que tiene que transcurrir hasta el próximo disparo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > proximoDisparo)
        {

            //Incremento el valor de proximo disparo
            proximoDisparo = Time.time + velocidadDisparo;

            //Instancio un nuevo disparo en esa posición y con esa rotación
            Instantiate(disparo, disparador.position, disparador.rotation);
        }

        input.y = joystick.Vertical * speed;
        input.x = joystick.Horizontal * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.deltaTime;
        transform.position += new Vector3(input.x, input.y, 0) * Time.deltaTime * speed;

        //GetRotationCangrejo();
        GetRotacion();
        //GetRotacionUniversoHorizontal();
        //GetRotacionUniversoVertical();
    }

    public void GetRotacion()
    {
        Vector2 lookDir = new Vector2(-input.x, input.y);
        shipAngle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;

        if (rb.rotation <= -90 && shipAngle >= 90)
        {
            rb.rotation += 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }
        else if (rb.rotation >= 90 && shipAngle <= -90)
        {
            rb.rotation -= 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }
        else
        {
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }
    }


    /*void GetRotacionUniversoHorizontal()
    {
        velocidadRotacionHorizontal = transform.position.x / 1000;
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * velocidadRotacionHorizontal);
    }
    */


    
}
    /*void GetRotationCangrejo()
    {
        Vector2 lookDir2 = new Vector3(-input.x, input.z);
        shipAngle2 = Mathf.Atan2(lookDir2.x, lookDir2.z) * Mathf.Rad2Deg;

        //Quaternion.AngleAxis(90f, Vector3 input.z);
        if (rb.rotation <= -90 && shipAngle2 >= 90)
        {
            Debug.Log("He entrado");
            //transform.Rotate(0, input.y, 0);
            rb.rotation += 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }
        else if (rb.rotation >= 90 && shipAngle2 <= -90)
        {
            rb.rotation -= 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle2, rotationInterpolation);
        }
        else
        {
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle2, rotationInterpolation);
        }
    }
}*/




/*void GetRotationCangrejo()
{
    Vector3 lookDir2 = new Vector2(-input.x, input.z);
    shipAngle2 = Mathf.Atan2(lookDir2.x, lookDir2.z) * Mathf.Rad2Deg;

    
    if (rb.rotation <= -90 && shipAngle2 >= 90)
    {
        Debug.Log("He entrado");
        //transform.Rotate(0, input.y, 0);
        rb.rotation += 360;
        rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
    }
    else if (rb.rotation >= 90 && shipAngle2 <= -90)
    {
        rb.rotation -= 360;
        rb.rotation = Mathf.Lerp(rb.rotation, shipAngle2, rotationInterpolation);
    }
    else
    {
        rb.rotation = Mathf.Lerp(rb.rotation, shipAngle2, rotationInterpolation);
    }
}
}
*/


/*  ****FUNCIONA CON EL AXIS CONTROLLER.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    Vector3 input;
    public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        input.y = joystick.Vertical * speed;
        input.x = joystick.Horizontal * speed;
        // input.x = Input.GetAxis("Horizontal");
        //input.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.deltaTime;
        transform.position += new Vector3(input.x, 0, input.y) * Time.deltaTime * speed;
    }
}
*/