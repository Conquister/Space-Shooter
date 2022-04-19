using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_PuntosDestruccion_F4 : MonoBehaviour
{

    public int puntuacion = 20;

    private void OnDestroy() {
        Score_F3.score += puntuacion;
    }
    
        
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
