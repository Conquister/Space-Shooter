using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Escudo_F3_Movimiento : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
