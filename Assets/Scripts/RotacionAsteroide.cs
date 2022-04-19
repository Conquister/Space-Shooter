using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAsteroide : MonoBehaviour
{
    private Rigidbody rig;
    public float VelozGiro;

    void Awake(){

        rig = GetComponent<Rigidbody>();
    }
   
   
    // Start is called before the first frame update
    void Start()
    {
       //Vector3 VelocidadGiro = new Vector3(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1)).normalized;
       rig.angularVelocity = Random.insideUnitSphere * VelozGiro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
