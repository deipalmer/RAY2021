using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decrementar : MonoBehaviour
{
    //David Pérez
    //Script para el decremento de los números
    // Start is called before the first frame update

    int edad = 25;
    void Awake()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void decrementaredad()
    {
        //decrementa la edad
        edad = edad - 1;
        if (edad <= 0)
        {
            Debug.Log("Se reinicia la edad");
            edad = 25;
        }
        Debug.Log("edad actual " + edad);
    
    }

}
