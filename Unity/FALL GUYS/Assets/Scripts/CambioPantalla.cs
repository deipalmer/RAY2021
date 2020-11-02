using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPantalla : MonoBehaviour
{

    public GameObject introduccion;
    public GameObject inicio;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            introduccion.SetActive(false);
            inicio.SetActive(true);
        }
    }
}
