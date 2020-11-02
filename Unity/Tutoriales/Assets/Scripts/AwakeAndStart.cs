using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    //Inicializa el script aunque no esté activo
    void Awake()
    {
        Debug.Log("Awake called");
    }

    /*Inicializa el script cuando está habilitado*/
    void Start()
    {
        Debug.Log("Start called");
    }
}
