using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{

    public GameObject pickupEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {
        //hacer spawn
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //aplicar efecto

        Destroy(gameObject);
    }
}
