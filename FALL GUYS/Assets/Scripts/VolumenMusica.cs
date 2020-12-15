using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenMusica : MonoBehaviour
{
    public AudioSource musica;
    public Slider volumen;
    // Start is called before the first frame update
    void Start()
    {
        musica.volume = volumen.value;
    }

    // Update is called once per frame
    public void CambiarVolumen()
    {
        musica.volume = volumen.value;
    }
}
