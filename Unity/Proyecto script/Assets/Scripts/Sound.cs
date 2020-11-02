using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource; 
    //newVolumen traerá un número entero hasta 10
    //Como el AudioSource el volumen va de 0 a 1, con decimales
    //vamos a dividir el nuevo valor del slider entre 10 para obtener
    //un número válido en el audiosource
    public void SetVolume(float newVolumen)
    {
        audioSource.volume = newVolumen / 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
