using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Sintaxis : MonoBehaviour
{
    // Start is called before the first frame update
    /*Se puede crear comentarios con barra asterisco!
     * Hay que finalizar con la exclamación!
     *Para acabar el comentario hay que usar asterisco barra!
     *Los comentarios pueden deshabilitar el codigo*/
    void Start()
    {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("Voy a chocar");
        }
    }
}
