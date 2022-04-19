using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPowerUp : MonoBehaviour
{
    public float vida;
    // Start is called before the first frame update

    void Update()
    {
        vida = Mathf.Clamp(vida, 0f, 100f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rayo" || other.gameObject.tag == "CapsulePowerUp" || other.gameObject.tag == "CapsulePowerUp2")
        {

        }
        else if(other.gameObject.tag == "Enemy" || other.gameObject.tag =="RayoBoss")
        {
            vida -= 25f;
        }

        if (vida == 0f)
        {
            gameObject.SetActive(false);
            vida = 100f;
            //Destroy(this.gameObject);
        }
    }
}
