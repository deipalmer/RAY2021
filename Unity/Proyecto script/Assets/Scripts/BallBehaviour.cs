using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //Lista pública de colores
    public Color[] Colors;
    public int colorIndex = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("He chocado con " + collision.gameObject.name);

            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Colors[colorIndex]);

            colorIndex = colorIndex + 1;
            if (colorIndex >= Colors.Length)
            {
                colorIndex = 0;
            }
        }
    }
}
