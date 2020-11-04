using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPantalla : MonoBehaviour
{

    public GameObject pantalla1;
    public GameObject pantalla2;
    public GameObject objetos;
    public GameObject barra;

    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            pantalla1.SetActive(false);
            pantalla2.SetActive(true);
            barra.SetActive(true);
            objetos.SetActive(true);
        }
    }
}
