using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides_Instanciar_F3 : MonoBehaviour
{
    public GameObject asteroide1;
    public GameObject asteroide2;
    public GameObject asteroide3;
    public Vector3 posicion;
    public int numeroEnemigos;
    public float esperaInicial;
    public float esperaEntreEnemigos;
    public float esperaEntreOlas;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(crearEnemigos());
    }

    IEnumerator crearEnemigos()
    {
        yield return new WaitForSeconds(esperaInicial);

        while (true)
        {
            for (int i = 0; i < numeroEnemigos; i++)
            {
                float a1posX = Random.Range(-25, -15);
                float b1posY = Random.Range(0, 24);
                Vector3 posicionAleatoria1 = new Vector3(a1posX, b1posY, -2);
                Instantiate(asteroide1, posicionAleatoria1, Quaternion.identity);

                float a2posX = Random.Range(-25, -15);
                float b2posY = Random.Range(0, 24);
                Vector3 posicionAleatoria2 = new Vector3(a2posX, b2posY, -2);
                Instantiate(asteroide2, posicionAleatoria2, asteroide2.transform.rotation);

                float a3posX = Random.Range(-25, -15);
                float b3posY = Random.Range(0, 24);
                Vector3 posicionAleatoria3 = new Vector3(a3posX, b3posY, -2);
                Instantiate(asteroide3, posicionAleatoria3, asteroide3.transform.rotation);

                yield return new WaitForSeconds(esperaEntreEnemigos);
            }
            yield return new WaitForSeconds(esperaEntreOlas);
        }

    }
}



//INSTANCIAR LOS 3 ASTEROIDES DE 1
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides_Instanciar : MonoBehaviour
{
    public GameObject asteroide1;
    public GameObject asteroide2;
    public GameObject asteroide3;
    private float rangoGeneracion = 9.0f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        float a1posX = Random.Range(-25, 15);
        float b1posY = Random.Range(0, 30);
        Vector3 posicionAleatoria1 = new Vector3(a1posX, b1posY, -2);
        float a2posX = Random.Range(-25, 15);
        float b2posY = Random.Range(0, 30);
        Vector3 posicionAleatoria2 = new Vector3(a2posX, b2posY, -2);
        float a3posX = Random.Range(-25, 15);
        float b3posY = Random.Range(0, 30);
        Vector3 posicionAleatoria3 = new Vector3(a3posX, b3posY, -2);
        Instantiate(asteroide1, posicionAleatoria1, Quaternion.identity);
        Instantiate(asteroide2, posicionAleatoria2, asteroide2.transform.rotation);
        Instantiate(asteroide3, posicionAleatoria3, asteroide3.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
