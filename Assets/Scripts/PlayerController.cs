using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[System.Serializable]
public class limites{
    public float xMax,xMin,zMax,zMin;
}


public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float Speed;
    private Rigidbody rig;
    public limites limite;
    public float Inclinacion;

    [Header("Disparo")]
    public GameObject Disparo;
    public Transform ApareceDisparo;
    public float TasaDisparo;
    private float ProximoDisparo;
    
    void Awake(){
       rig = GetComponent<Rigidbody>(); 
    }

    void Start(){
        UpdateLimite();
    }

    void UpdateLimite(){
        Vector2 mitad = Utils.GetDimensionsInWorldUnits() / 2;
        limite.xMin = -mitad.x + 0.7f;
        limite.xMax = mitad.x - 0.7f;

        limite.zMin = -mitad.y + 6f;
        limite.zMax = mitad.y - 2f;
    }

    // Update is called once per frame
    void Update(){
        if(CrossPlatformInputManager.GetButton("Fire1") && Time.time > ProximoDisparo ){
            ProximoDisparo = Time.time + TasaDisparo;
            Instantiate(Disparo, ApareceDisparo.position, Quaternion.identity);
        }
    }
    void FixedUpdate(){
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rig.velocity = movement * Speed;
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, limite.xMin, limite.xMax), 0f, Mathf.Clamp(rig.position.z, limite.zMin, limite.zMax));
        rig.rotation = Quaternion.Euler(0f,0f,rig.velocity.x * -Inclinacion);
    }
}
