using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_PowerUps_VelocidadDisparos_Instanciar_F4 : MonoBehaviour
{
    public GameObject powerUp_escudo;
    public Vector3 posicion;
    public int numeroPowerUps;
    public float esperaInicial;
    public float esperaEntrePowerUps;
    public float esperaEntreOlas;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(crearPowerUps());
    }

    IEnumerator crearPowerUps()
    {
        yield return new WaitForSeconds(esperaInicial);

        while (true)
        {
            for (int i = 0; i < numeroPowerUps; i++)
            {
                float PUposX = Random.Range(-5.5f, 5.5f);
                float PUposY = 25;
                Vector3 posicionAleatoria1 = new Vector3(PUposX, PUposY, -2);
                Instantiate(powerUp_escudo, posicionAleatoria1, Quaternion.identity);

                yield return new WaitForSeconds(esperaEntrePowerUps);
            }
            yield return new WaitForSeconds(esperaEntreOlas);
        }

    }
}



