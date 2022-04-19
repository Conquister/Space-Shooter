using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorLimite : MonoBehaviour
{
    void OnTriggerExit(Collider otro){
        Destroy(otro.gameObject);
    }
}
