using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide_Rotation : MonoBehaviour
{
    private Rigidbody rb;
    public float speedRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.angularVelocity = Random.insideUnitSphere * speedRotation;
    }
}
