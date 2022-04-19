using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverRayoBoss : MonoBehaviour
{
    private Rigidbody rig;
    public float Velocidad;
    // Start is called before the first frame update
    
    void Awake(){
        rig = GetComponent<Rigidbody>();
    }

    
    void Start()
    {
        rig.velocity = transform.up* Velocidad;
    }


        
    
}
